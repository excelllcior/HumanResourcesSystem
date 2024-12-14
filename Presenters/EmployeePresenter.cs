using System;
using System.Data;
using HumanResourcesSystem.Views;
using HumanResourcesSystem.Repositories;
using HumanResourcesSystem.Presenters.Common;
using HumanResourcesSystem.Repositories.Contracts;
using HumanResourcesSystem.Models;
using System.Resources;
using System.Linq;
using System.Windows.Forms;
using HumanResourcesSystem.Properties;
using HumanResourcesSystem.Views.Contracts;
using System.Collections.Generic;

namespace HumanResourcesSystem.Presenters
{
    public class EmployeePresenter
    {
        private readonly IEmployeeView employeeView;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IPositionRepository positionRepository;
        private readonly ILevelRepository levelRepository;
        private readonly IEmployeeSkillRepository employeeSkillRepository;
        private DataTable employeeDataTable;
        private DataTable positionDataTable;
        private DataTable levelDataTable;

        private List<EmployeeSkill> employeeSkills;

        private readonly string[] employeeDataTableColumnNames = {
            "Id", "Фамилия", "Имя", "Отчество", "Дата рождения",
            "Серия паспорта", "Номер паспорта", "Кем выдан", "Когда выдан", "Адрес регистрации", "Адрес факт. проживания", 
            "Номер телефона", "Email", "Telegram",
            "Id Должность", "Должность", "Id Уровень", "Уровень"
        };

        private readonly string[] positionDataTableColumnNames = {
            "Id", "Наименование"
        };

        private readonly string[] levelDataTableColumnNames = {
            "Id", "Наименование"
        };

        private readonly string[] employeeSkillDataTableColumnNames = {
            "Id", "Наименование", "Уровень навыка"
        };

        public EmployeePresenter(IEmployeeView employeeView)
        {
            this.employeeView = employeeView;
            employeeRepository = new EmployeeRepository();
            positionRepository = new PositionRepository();
            levelRepository = new LevelRepository();
            employeeSkillRepository = new EmployeeSkillRepository();

            employeeSkills = new List<EmployeeSkill>();

            LoadPositions();
            LoadLevels();
            LoadEmployees();
            LoadEmployeeSkills();
            AssociateViewEventsWithPresenterEvents();
        }

        private void AssociateViewEventsWithPresenterEvents()
        {
            employeeView.AddEmployeeEvent += AddEmployee;
            employeeView.EditEmployeeEvent += EditEmployee;
            employeeView.RemoveEmployeeEvent += RemoveEmployee;
            employeeView.SaveChangesEvent += SaveChanges;
            employeeView.CancelChangesEvent += CancelChanges;
            employeeView.ShowPositionViewEvent += ShowPositionView;
            employeeView.ShowLevelViewEvent += ShowLevelView;
            employeeView.AddEmployeeSkillEvent += AddEmployeeSkill;
            employeeView.RemoveEmployeeEvent += RemoveEmployeeSkill;
        }

        private void LoadEmployees()
        {
            var employees = employeeRepository.GetEmployees();

            employeeDataTable = new DataTable();

            foreach (var column in employeeDataTableColumnNames)
            {
                employeeDataTable.Columns.Add(column);
            }

            foreach (Employee employee in employees)
            {
                var row = employeeDataTable.NewRow();
                row[0] = employee.EmployeeId;
                row[1] = employee.LastName;
                row[2] = employee.FirstName;
                row[3] = employee.MiddleName;
                row[4] = employee.BirthDate.ToString("dd.MM.yyyy"); ;
                row[5] = employee.PassportSeries;
                row[6] = employee.PassportNumber;
                row[7] = employee.IssuedBy;
                row[8] = employee.IssueDate.ToString("dd.MM.yyyy"); ;
                row[9] = employee.RegistrationAddress;
                row[10] = employee.ActualAddress;
                row[11] = employee.PhoneNumber;
                row[12] = employee.Email;
                row[13] = employee.Telegram;
                row[14] = employee.PositionId;
                row[15] = positionDataTable.Select($"{positionDataTableColumnNames[0]} = {employee.PositionId}").FirstOrDefault()[1];
                row[16] = employee.LevelId;
                row[17] = levelDataTable.Select($"{levelDataTableColumnNames[0]} = {employee.LevelId}").FirstOrDefault()[1];

                employeeDataTable.Rows.Add(row);
            }

            employeeView.FillDataGridViewEmployees(employeeDataTable);
        }

        private void LoadPositions()
        {
            var positions = positionRepository.GetPositions();

            positionDataTable = new DataTable();

            foreach (var column in positionDataTableColumnNames)
            {
                positionDataTable.Columns.Add(column);
            }

            var defaultComboBoxRow = positionDataTable.NewRow();

            defaultComboBoxRow[positionDataTableColumnNames[0]] = 0;
            defaultComboBoxRow[positionDataTableColumnNames[1]] = "Не выбрано";

            positionDataTable.Rows.Add(defaultComboBoxRow);

            foreach (var position in positions)
            {
                var row = positionDataTable.NewRow();

                row[positionDataTableColumnNames[0]] = position.PositionId;
                row[positionDataTableColumnNames[1]] = position.PositionName;

                positionDataTable.Rows.Add(row);
            }

            employeeView.FillComboBoxPositions(positionDataTable);
        }

        private void LoadLevels()
        {
            var levels = levelRepository.GetLevels();

            levelDataTable = new DataTable();

            foreach (var column in levelDataTableColumnNames)
            {
                levelDataTable.Columns.Add(column);
            }

            var defaultComboBoxRow = levelDataTable.NewRow();

            defaultComboBoxRow[levelDataTableColumnNames[0]] = 0;
            defaultComboBoxRow[levelDataTableColumnNames[1]] = "Не выбрано";

            levelDataTable.Rows.Add(defaultComboBoxRow);

            foreach (var level in levels)
            {
                var row = levelDataTable.NewRow();

                row[levelDataTableColumnNames[0]] = level.LevelId;
                row[levelDataTableColumnNames[1]] = level.LevelName;

                levelDataTable.Rows.Add(row);
            }

            employeeView.FillComboBoxPositions(levelDataTable);
        }

        private void LoadEmployeeSkills()
        {
            
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            employeeView.IsEdit = false;
        }

        private void EditEmployee(object sender, EventArgs e)
        {
            employeeView.IsEdit = true;

            DataRow selectedRow = employeeDataTable.AsEnumerable()
                .FirstOrDefault(row => Convert.ToInt32(row[0]) == employeeView.SelectedEmployeeId);

            if (selectedRow != null)
            {
                employeeView.LastName = selectedRow[1].ToString();
                employeeView.FirstName = selectedRow[2].ToString();
                employeeView.MiddleName = selectedRow[3].ToString();
                employeeView.BirthDate = Convert.ToDateTime(selectedRow[4]);
                employeeView.PassportSeries = selectedRow[5].ToString();
                employeeView.PassportNumber = selectedRow[6].ToString();
                employeeView.IssuedBy = selectedRow[7].ToString();
                employeeView.IssueDate = Convert.ToDateTime(selectedRow[8]);
                employeeView.RegistrationAddress = selectedRow[9].ToString();
                employeeView.ActualAddress = selectedRow[10].ToString();
                employeeView.PhoneNumber = selectedRow[11].ToString();
                employeeView.Email = selectedRow[12].ToString();
                employeeView.Telegram = selectedRow[13].ToString();
                employeeView.PositionId = Convert.ToInt32(selectedRow[14].ToString());
                employeeView.LevelId = Convert.ToInt32(selectedRow[16].ToString());
            }
        }

        private void RemoveEmployee(object sender, EventArgs e)
        {
            try
            {
                employeeRepository.DeleteEmployee(employeeView.SelectedEmployeeId);
                employeeView.IsSuccessful = true;
                employeeView.Message = Resources.MessageSuccessfulDelete;

                LoadEmployees();
            }
            catch (Exception ex)
            {
                employeeView.IsSuccessful = false;
                employeeView.Message = ex.Message;
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            try
            {
                if (Validation.ValidateStringValue(employeeView.LastName, employeeDataTableColumnNames[1], true))
                    employee.LastName = employeeView.LastName;

                if (Validation.ValidateStringValue(employeeView.FirstName, employeeDataTableColumnNames[2], true))
                    employee.FirstName = employeeView.FirstName;

                if (Validation.ValidateStringValueAsNullableString(employeeView.MiddleName, employeeDataTableColumnNames[3], true))
                    employee.MiddleName = employeeView.MiddleName;

                if (Validation.ValidateDateTimeValue(employeeView.BirthDate, employeeDataTableColumnNames[4]))
                    employee.BirthDate = employeeView.BirthDate;

                if (Validation.ValidateStringValueAsInt(employeeView.PassportSeries, employeeDataTableColumnNames[5], 0, 9999, 4, 4))
                    employee.PassportSeries = Convert.ToInt32(employeeView.PassportSeries);

                if (Validation.ValidateStringValueAsInt(employeeView.PassportNumber, employeeDataTableColumnNames[6], 0, 999999, 6, 6))
                    employee.PassportNumber = Convert.ToInt32(employeeView.PassportNumber);

                if (Validation.ValidateStringValue(employeeView.IssuedBy, employeeDataTableColumnNames[7]))
                    employee.IssuedBy = employeeView.IssuedBy;

                if (Validation.ValidateDateTimeValue(employeeView.IssueDate, employeeDataTableColumnNames[8]))
                    employee.IssueDate = employeeView.IssueDate;

                if (Validation.ValidateStringValue(employeeView.RegistrationAddress, employeeDataTableColumnNames[9]))
                    employee.RegistrationAddress = employeeView.RegistrationAddress;

                if (Validation.ValidateStringValue(employeeView.ActualAddress, employeeDataTableColumnNames[10]))
                    employee.ActualAddress = employeeView.ActualAddress;

                if (Validation.ValidateStringValueAsPhoneNumber(employeeView.PhoneNumber, employeeDataTableColumnNames[11]))
                    employee.PhoneNumber = employeeView.PhoneNumber;

                if (Validation.ValidateStringValueAsEmail(employeeView.Email, employeeDataTableColumnNames[11]))
                    employee.Email = employeeView.Email;

                if (Validation.ValidateStringValueAsTelegram(employeeView.Telegram, employeeDataTableColumnNames[12]))
                    employee.Telegram = employeeView.Telegram;

                if (employeeView.PositionId == 0)
                    throw new Exception(string.Format(Resources.WarningSelectComboBoxValue, employeeDataTableColumnNames[14]));

                if (employeeView.LevelId == 0)
                    throw new Exception(string.Format(Resources.WarningSelectComboBoxValue, employeeDataTableColumnNames[16]));

                switch (employeeView.IsEdit)
                {
                    case false:
                        employeeRepository.InsertEmployee(employee);
                        employeeView.Message = Resources.MessageSuccessfulInsert;
                        break;
                    case true:
                        employeeRepository.UpdateEmployee(employee);
                        employeeView.Message = Resources.MessageSuccessfulUpdate;
                        break;
                }

                LoadEmployees();
                LoadEmployeeSkills();
                ResetViewFields();
                employeeView.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                employeeView.IsSuccessful = false;
                employeeView.Message = ex.Message;
            }
        }

        private void CancelChanges(object sender, EventArgs e)
        {
            ResetViewFields();
        }

        private void ShowPositionView(object sender, EventArgs e)
        {
            var positionView = new PositionView();
            _ = new PositionPresenter(positionView);

            positionView.PositionSelectedEvent += delegate
            {
                employeeView.PositionId = positionView.SelectedPositionId;
                positionView.Close();
            };

            positionView.ShowDialog();

            var position = positionRepository.GetPosition(employeeView.PositionId);

            if (position == null)
            {
                employeeView.PositionId = 0;
            }

            LoadPositions();
        }

        private void ShowLevelView(object sender, EventArgs e)
        {
            var levelView = new LevelView();
            _ = new LevelPresenter(levelView);

            levelView.LevelSelectedEvent += delegate
            {
                employeeView.LevelId = levelView.SelectedLevelId;
                levelView.Close();
            };

            levelView.ShowDialog();

            var level = levelRepository.GetLevel(employeeView.LevelId);

            if (level == null)
            {
                employeeView.LevelId = 0;
            }

            LoadLevels();
        }

        private void AddEmployeeSkill(object sender, EventArgs e)
        {
            var skillView = new SkillView();
            _ = new SkillPresenter(skillView);

            skillView.SkillSelectedEvent += delegate
            {
                var employeeSkillView = new EmployeeSkillView();
                _ = new EmployeeSkillPresenter(employeeSkillView);

                employeeSkillView.ShowDialog();

                employeeSkillView.SaveEvent += delegate
                {
                    var employeeSkill = new EmployeeSkill();

                    employeeSkillView.EmployeeId = employeeView.SelectedEmployeeId;
                    employeeSkillView.SkillId = employeeView.SelectedEmployeeSkillId;

                    try
                    {
                        if (Validation.ValidateStringValueAsInt(employeeSkillView.SkillLevel, "Уровень навыка", 0, 10, 1, 1))
                            employeeSkill.SkillLevel = Convert.ToInt32(employeeSkillView.SkillLevel);

                        employeeSkillView.Message = "Навык успешно добавлен";
                        employeeSkillView.IsSuccessful = true;
                    }
                    catch (Exception ex)
                    {
                        employeeSkillView.Message = ex.Message;
                        employeeSkillView.IsSuccessful = false;
                    }

                    employeeSkills.Add(employeeSkill);
                    Console.WriteLine(employeeSkills.Count);

                    employeeSkillView.Close();
                };

                skillView.Close();
            };

            skillView.ShowDialog();
        }

        private void RemoveEmployeeSkill(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ResetViewFields()
        {
            employeeView.LastName = string.Empty;
            employeeView.FirstName = string.Empty;
            employeeView.MiddleName = string.Empty;
            employeeView.BirthDate = DateTime.Now;
            employeeView.PassportSeries = string.Empty;
            employeeView.PassportNumber = string.Empty;
            employeeView.IssuedBy = string.Empty;
            employeeView.IssueDate = DateTime.Now;
            employeeView.RegistrationAddress = string.Empty;
            employeeView.ActualAddress = string.Empty;
            employeeView.PositionId = 0;
            employeeView.LevelId = 0;
            employeeView.PhoneNumber = string.Empty;
            employeeView.Email = string.Empty;
            employeeView.Telegram = string.Empty;
        }
    }
}
