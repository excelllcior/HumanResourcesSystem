using System;
using System.Data;

namespace HumanResourcesSystem.Views
{
    public interface ILevelView
    {
        int SelectedLevelId { get; }
        string LevelName { get; set; }
        string SalaryCoefficient { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler AddLevelEvent;
        event EventHandler EditLevelEvent;
        event EventHandler RemoveLevelEvent;
        event EventHandler SaveChangesEvent;
        event EventHandler CancelChangesEvent;
        event EventHandler LevelSelectedEvent;

        void FillDataGridViewLevels(DataTable dataTable);
    }
}
