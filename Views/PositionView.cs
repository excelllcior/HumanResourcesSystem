using System;
using System.Data;
using System.Windows.Forms;
using HumanResourcesSystem.Properties;

namespace HumanResourcesSystem.Views
{
    public partial class PositionView : Form, IPositionView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public int SelectedPositionId
        {
            get
            {
                int selectedPositionId = 0;

                if (dataGridViewPositions.Rows.Count > 0)
                {
                    int selectedRowIndex = dataGridViewPositions.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewPositions.Rows[selectedRowIndex];
                    selectedPositionId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                }

                return selectedPositionId;
            }
        }

        public string PositionName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public string Salary
        {
            get { return textBoxSalary.Text; }
            set { textBoxSalary.Text = value; }
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

        public event EventHandler AddPositionEvent;
        public event EventHandler EditPositionEvent;
        public event EventHandler RemovePositionEvent;
        public event EventHandler SaveChangesEvent;
        public event EventHandler CancelChangesEvent;
        public event EventHandler PositionSelectedEvent;

        public PositionView()
        {
            InitializeComponent();
            AssociateControlEventsWithViewEvents();
        }

        private void AssociateControlEventsWithViewEvents()
        {
            buttonAddPosition.Click += ButtonAddPositionClicked;
            buttonEditPosition.Click += ButtonEditPositionClicked;
            buttonRemovePosition.Click += ButtonRemovePositionClicked;
            buttonOK.Click += ButtonOKClicked;
            buttonCancel.Click += ButtonCancelClicked;
            dataGridViewPositions.CellDoubleClick += DataGridViewPositionsCellDoubleClicked;
        }

        private void ButtonAddPositionClicked(object sender, EventArgs e)
        {
            dataGridViewPositions.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            AddPositionEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEditPositionClicked(object sender, EventArgs e)
        {
            if (SelectedPositionId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToUpdate, Resources.CaptionUpdate,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            dataGridViewPositions.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            EditPositionEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonRemovePositionClicked(object sender, EventArgs e)
        {
            if (SelectedPositionId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToDelete, Resources.CaptionDelete,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                Resources.WarningConfirmDelete, Resources.CaptionDelete,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    RemovePositionEvent?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show(
                        Message, Resources.CaptionDelete,
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void ButtonOKClicked(object sender, EventArgs e)
        {
            SaveChangesEvent?.Invoke(this, EventArgs.Empty);

            string caption;
            if (isEdit)
            {
                caption = Resources.CaptionUpdate;
            }
            else
            {
                caption = Resources.CaptionInsert;
            }

            switch (isSuccessful)
            {
                case true:
                    dataGridViewPositions.Visible = true;
                    panelEditForm.Visible = false;
                    ToggleActionButtons(true);

                    if (!isEdit && dataGridViewPositions.Rows.Count > 0)
                    {
                        dataGridViewPositions.Rows[dataGridViewPositions.RowCount - 1].Selected = true;
                    }

                    MessageBox.Show(
                        Message, caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    break;

                case false:
                    MessageBox.Show(
                        Message, caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );

                    break;
            }
        }

        private void ButtonCancelClicked(object sender, EventArgs e)
        {
            dataGridViewPositions.Visible = true;
            panelEditForm.Visible = false;
            ToggleActionButtons(true);

            CancelChangesEvent?.Invoke(this, EventArgs.Empty);
        }

        private void DataGridViewPositionsCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            PositionSelectedEvent?.Invoke(this, EventArgs.Empty);
        }

        public void FillDataGridViewPositions(DataTable positionDataTable)
        {
            dataGridViewPositions.DataSource = positionDataTable;
        }

        private void ToggleActionButtons(bool enabled)
        {
            buttonAddPosition.Enabled = enabled;
            buttonEditPosition.Enabled = enabled;
            buttonRemovePosition.Enabled = enabled;
        }
    }
}
