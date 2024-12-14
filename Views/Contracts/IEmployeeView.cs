using System;
using System.Data;

namespace HumanResourcesSystem.Views
{
    public interface IEmployeeView
    {
        int SelectedEmployeeId { get; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        DateTime BirthDate { get; set; }
        string PassportSeries { get; set; }
        string PassportNumber { get; set; }
        string IssuedBy { get; set; }
        DateTime IssueDate { get; set; }
        string RegistrationAddress { get; set; }
        string ActualAddress { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Telegram { get; set; }
        int PositionId { get; set; }
        int LevelId { get; set; }
        int SelectedEmployeeSkillId { get; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler AddEmployeeEvent;
        event EventHandler EditEmployeeEvent;
        event EventHandler RemoveEmployeeEvent;
        event EventHandler ShowPositionViewEvent;
        event EventHandler ShowLevelViewEvent;
        event EventHandler AddEmployeeSkillEvent;
        event EventHandler RemoveEmployeeSkillEvent;
        event EventHandler SaveChangesEvent;
        event EventHandler CancelChangesEvent;

        void FillDataGridViewEmployees(DataTable employeeDataTable);
        void FillComboBoxPositions(DataTable positionDataTable);
        void FillComboBoxLevels(DataTable levelDataTable);
        void FillDataGridViewEmployeeSkills(DataTable employeeSkillDataTable);
    }
}
