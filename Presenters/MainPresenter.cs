using System;
using HumanResourcesSystem.Views;

namespace HumanResourcesSystem.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView mainView;

        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;

            AssociateViewEventsWithPresenterEvents();
        }

        private void AssociateViewEventsWithPresenterEvents()
        {
            mainView.ShowSkillViewEvent += ShowSkillView;
            mainView.ShowLevelViewEvent += ShowLevelView;
            mainView.ShowPositionViewEvent += ShowPositionView;
            mainView.ShowEmployeeViewEvent += ShowEmployeeView;
            mainView.ShowProjectViewEvent += ShowProjectView;
        }

        private void ShowSkillView(object sender, EventArgs e)
        {
            var skillView = new SkillView();
            _ = new SkillPresenter(skillView);

            skillView.ShowDialog();
        }

        private void ShowLevelView(object sender, EventArgs e)
        {
            var levelView = new LevelView();
            _ = new LevelPresenter(levelView);

            levelView.ShowDialog();
        }

        private void ShowEmployeeView(object sender, EventArgs e)
        {
            var employeeView = new EmployeeView();
            _ = new EmployeePresenter(employeeView);

            employeeView.ShowDialog();
        }

        private void ShowPositionView(object sender, EventArgs e)
        {
            var positionView = new PositionView();
            _ = new PositionPresenter(positionView);

            positionView.ShowDialog();
        }

        private void ShowProjectView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
