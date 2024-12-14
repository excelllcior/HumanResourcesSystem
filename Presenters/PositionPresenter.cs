using System;
using System.Data;
using System.Linq;
using HumanResourcesSystem.Views;
using HumanResourcesSystem.Models;
using HumanResourcesSystem.Properties;
using HumanResourcesSystem.Repositories;
using HumanResourcesSystem.Presenters.Common;

namespace HumanResourcesSystem.Presenters
{
    public class PositionPresenter
    {
        private readonly IPositionView positionView;
        private readonly IPositionRepository positionRepository;
        private DataTable positionDataTable;

        private readonly string[] positionDataTableColumnNames = {
            "Id", "Наименование", "Зарплата"
        };

        public PositionPresenter(IPositionView positionView)
        {
            this.positionView = positionView;
            positionRepository = new PositionRepository();

            LoadPositions();
            AssociateViewEventsWithPresenterEvents();
        }

        private void AssociateViewEventsWithPresenterEvents()
        {
            positionView.AddPositionEvent += AddPosition;
            positionView.EditPositionEvent += EditPosition;
            positionView.RemovePositionEvent += RemovePosition;
            positionView.SaveChangesEvent += SaveChanges;
            positionView.CancelChangesEvent += CancelChanges;
        }

        private void LoadPositions()
        {
            var positions = positionRepository.GetPositions();

            positionDataTable = new DataTable();

            foreach (var column in positionDataTableColumnNames)
            {
                positionDataTable.Columns.Add(column);
            }

            foreach (var position in positions)
            {
                var row = positionDataTable.NewRow();

                row[positionDataTableColumnNames[0]] = position.PositionId;
                row[positionDataTableColumnNames[1]] = position.PositionName;
                row[positionDataTableColumnNames[2]] = position.Salary;

                positionDataTable.Rows.Add(row);
            }

            positionView.FillDataGridViewPositions(positionDataTable);
        }

        private void AddPosition(object sender, EventArgs e)
        {
            positionView.IsEdit = false;
        }

        private void EditPosition(object sender, EventArgs e)
        {
            positionView.IsEdit = true;

            DataRow selectedRow = positionDataTable.AsEnumerable()
                .FirstOrDefault(row => Convert.ToInt32(row[0]) == positionView.SelectedPositionId);

            if (selectedRow != null)
            {
                positionView.PositionName = selectedRow[1].ToString();
                positionView.Salary = selectedRow[2].ToString();
            }
        }

        private void RemovePosition(object sender, EventArgs e)
        {
            try
            {
                positionRepository.DeletePosition(positionView.SelectedPositionId);
                positionView.IsSuccessful = true;
                positionView.Message = Resources.MessageSuccessfulDelete;

                LoadPositions();
            }
            catch (Exception ex)
            {
                positionView.IsSuccessful = false;
                positionView.Message = ex.Message;
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            Position position = new Position();

            try
            {
                if (Validation.ValidateStringValue(positionView.PositionName, positionDataTableColumnNames[1]))
                    position.PositionName = positionView.PositionName;

                if (Validation.ValidateStringValueAsDouble(positionView.Salary, positionDataTableColumnNames[2]))
                    position.Salary = Convert.ToDouble(positionView.Salary);

                switch (positionView.IsEdit)
                {
                    case false:
                        positionRepository.InsertPosition(position);
                        positionView.Message = Resources.MessageSuccessfulInsert;
                        break;
                    case true:
                        positionRepository.UpdatePosition(position);
                        positionView.Message = Resources.MessageSuccessfulUpdate;
                        break;
                }

                LoadPositions();
                ResetViewFields();
                positionView.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                positionView.IsSuccessful = false;
                positionView.Message = ex.Message;
            }
        }

        private void CancelChanges(object sender, EventArgs e)
        {
            ResetViewFields();
        }

        private void ResetViewFields()
        {
            positionView.PositionName = string.Empty;
            positionView.Salary = string.Empty;
        }
    }
}
