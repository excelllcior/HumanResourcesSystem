using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HumanResourcesSystem.Views
{
    public partial class EmployeeSkillView : Form, IEmployeeSkillView
    {
        private int employeeId;
        private int skillId;
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public int SkillId
        {
            get { return skillId; }
            set { skillId = value; }
        }

        public string SkillLevel
        {
            get { return textBoxSkillLevel.Text; }
            set { textBoxSkillLevel.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SaveEvent;

        public EmployeeSkillView()
        {
            InitializeComponent();
            AssociateControlEventsWithViewEvents();
        }

        private void AssociateControlEventsWithViewEvents()
        {
            buttonSave.Click += ButtonSaveClicked;
        }

        private void ButtonSaveClicked(object sender, EventArgs e)
        {
            SaveEvent?.Invoke(this, EventArgs.Empty);

            switch (isSuccessful)
            {
                case true:
                    MessageBox.Show(
                        Message, "Добавление навыка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                    break;
                case false:
                    MessageBox.Show(
                        Message, "!Добавление навыка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                    break;
            }
        }
    }
}
