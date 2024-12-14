using System;
using System.Data;
using System.Linq;
using HumanResourcesSystem.Views;
using HumanResourcesSystem.Models;
using HumanResourcesSystem.Properties;
using HumanResourcesSystem.Repositories;
using HumanResourcesSystem.Presenters.Common;
using HumanResourcesSystem.Repositories.Contracts;

namespace HumanResourcesSystem.Presenters
{
    public class LevelPresenter
    {
        private readonly ILevelView levelView;
        private readonly ILevelRepository levelRepository;
        private DataTable levelDataTable;

        private readonly string[] levelDataTableColumnNames = {
            "Id", "Наименование", "Коэффициент"
        };

        public LevelPresenter(ILevelView levelView)
        {
            this.levelView = levelView;
            levelRepository = new LevelRepository();

            LoadLevels();
            AssociateViewEventsWithPresenterEvents();
        }

        private void AssociateViewEventsWithPresenterEvents()
        {
            levelView.AddLevelEvent += AddLevel;
            levelView.EditLevelEvent += EditLevel;
            levelView.RemoveLevelEvent += RemoveLevel;
            levelView.SaveChangesEvent += SaveChanges;
            levelView.CancelChangesEvent += CancelChanges;
        }

        private void LoadLevels()
        {
            var levels = levelRepository.GetLevels();

            levelDataTable = new DataTable();

            foreach (var column in levelDataTableColumnNames)
            {
                levelDataTable.Columns.Add(column);
            }

            foreach (var level in levels)
            {
                var row = levelDataTable.NewRow();

                row[levelDataTableColumnNames[0]] = level.LevelId;
                row[levelDataTableColumnNames[1]] = level.LevelName;
                row[levelDataTableColumnNames[2]] = level.SalaryCoefficient;

                levelDataTable.Rows.Add(row);
            }

            levelView.FillDataGridViewLevels(levelDataTable);
        }

        private void AddLevel(object sender, EventArgs e)
        {
            levelView.IsEdit = false;
        }

        private void EditLevel(object sender, EventArgs e)
        {
            levelView.IsEdit = true;

            DataRow selectedRow = levelDataTable.AsEnumerable()
                .FirstOrDefault(row => Convert.ToInt32(row[0]) == levelView.SelectedLevelId);

            if (selectedRow != null)
            {
                levelView.LevelName = selectedRow[1].ToString();
                levelView.SalaryCoefficient = selectedRow[2].ToString();
            }
        }

        private void RemoveLevel(object sender, EventArgs e)
        {
            try
            {
                levelRepository.DeleteLevel(levelView.SelectedLevelId);
                levelView.IsSuccessful = true;
                levelView.Message = Resources.MessageSuccessfulDelete;

                LoadLevels();
            }
            catch (Exception ex)
            {
                levelView.IsSuccessful = false;
                levelView.Message = ex.Message;
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            Level level = new Level();

            try
            {
                if (Validation.ValidateStringValue(levelView.LevelName, levelDataTableColumnNames[1]))
                    level.LevelName = levelView.LevelName;

                if (Validation.ValidateStringValueAsDouble(levelView.SalaryCoefficient, levelDataTableColumnNames[2]))
                    level.SalaryCoefficient = Convert.ToDouble(levelView.SalaryCoefficient);

                switch (levelView.IsEdit)
                {
                    case false:
                        levelRepository.InsertLevel(level);
                        levelView.Message = Resources.MessageSuccessfulInsert;
                        break;
                    case true:
                        levelRepository.UpdateLevel(level);
                        levelView.Message = Resources.MessageSuccessfulUpdate;
                        break;
                }

                LoadLevels();
                ResetViewFields();
                levelView.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                levelView.IsSuccessful = false;
                levelView.Message = ex.Message;
            }
        }

        private void CancelChanges(object sender, EventArgs e)
        {
           ResetViewFields();
        }

        private void ResetViewFields()
        {
            levelView.LevelName = string.Empty;
            levelView.SalaryCoefficient = string.Empty;
        }
    }
}
