using System;

namespace HumanResourcesSystem
{
    public interface IMainView
    {
        event EventHandler ShowSkillViewEvent;
        event EventHandler ShowLevelViewEvent;
        event EventHandler ShowPositionViewEvent;
        event EventHandler ShowEmployeeViewEvent;
        event EventHandler ShowProjectViewEvent;
    }
}
