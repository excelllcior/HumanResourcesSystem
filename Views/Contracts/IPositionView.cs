using System;
using System.Data;

namespace HumanResourcesSystem.Views
{
    public interface IPositionView
    {
        int SelectedPositionId { get; }
        string PositionName { get; set; }
        string Salary { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler AddPositionEvent;
        event EventHandler EditPositionEvent;
        event EventHandler RemovePositionEvent;
        event EventHandler SaveChangesEvent;
        event EventHandler CancelChangesEvent;
        event EventHandler PositionSelectedEvent;

        void FillDataGridViewPositions(DataTable positionDataTable);
    }
}
