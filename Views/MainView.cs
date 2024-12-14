using System;
using System.Windows.Forms;

namespace HumanResourcesSystem
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateControlEventsWithViewEvents();
        }

        public event EventHandler ShowSkillViewEvent;
        public event EventHandler ShowLevelViewEvent;
        public event EventHandler ShowPositionViewEvent;
        public event EventHandler ShowEmployeeViewEvent;
        public event EventHandler ShowProjectViewEvent;

        private void AssociateControlEventsWithViewEvents()
        {
            toolStripCatalogsSkills.Click += ToolStripCatalogsSkillsClicked;
            toolStripCatalogsLevels.Click += ToolStripCatalogsLevelsClicked;
            toolStripCatalogsPositions.Click += ToolStripCatalogsPositionsClicked;
            toolStripCatalogsEmployees.Click += ToolStripCatalogEmployeesClicked;
            toolStripCatalogsProjects.Click += ToolStripCatalogProjectsClicked;
        }

        private void ToolStripCatalogsSkillsClicked(object sender, EventArgs e)
        {
            ShowSkillViewEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ToolStripCatalogsLevelsClicked(object sender, EventArgs e)
        {
            ShowLevelViewEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ToolStripCatalogsPositionsClicked(object sender, EventArgs e)
        {
            ShowPositionViewEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ToolStripCatalogEmployeesClicked(object sender, EventArgs e)
        {
            ShowEmployeeViewEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ToolStripCatalogProjectsClicked(object sender, EventArgs e)
        {
            ShowProjectViewEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
