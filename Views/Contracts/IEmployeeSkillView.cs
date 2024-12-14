using System;

namespace HumanResourcesSystem.Views
{
    public interface IEmployeeSkillView
    {
        int EmployeeId { get; set; }
        int SkillId { get; set; }
        string SkillLevel { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SaveEvent;
    }
}
