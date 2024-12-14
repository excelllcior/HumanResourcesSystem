using System;
using System.Data;

namespace HumanResourcesSystem.Views
{
    public interface ISkillView
    {
        int SelectedSkillId { get; }
        string SkillName { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler AddSkillEvent;
        event EventHandler EditSkillEvent;
        event EventHandler RemoveSkillEvent;
        event EventHandler SaveChangesEvent;
        event EventHandler CancelChangesEvent;
        event EventHandler SkillSelectedEvent;

        void FillDataGridViewSkills(DataTable skillDataTable);
    }
}
