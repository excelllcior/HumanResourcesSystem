using HumanResourcesSystem.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace HumanResourcesSystem.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public int SelectedEmployeeId
        {
            get
            {
                int selectedEmployeeId = 0;

                if (dataGridViewEmployees.Rows.Count > 0)
                {
                    int selectedRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewEmployees.Rows[selectedRowIndex];
                    selectedEmployeeId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                }

                return selectedEmployeeId;
            }
        }

        public string LastName {
            get { return textBoxLastName.Text; }
            set { textBoxLastName.Text = value; }
        }

        public string FirstName {
            get { return textBoxFirstName.Text; }
            set { textBoxFirstName.Text = value; }
        }

        public string MiddleName {
            get { return textBoxMiddleName.Text; }
            set { textBoxMiddleName.Text = value; }
        }

        public DateTime BirthDate {
            get { return dateTimePickerBirthDate.Value; }
            set { dateTimePickerBirthDate.Value = value; }
        }

        public string PassportSeries {
            get { return textBoxPassportSeries.Text; }
            set { textBoxPassportSeries.Text = value; }
        }

        public string PassportNumber {
            get { return textBoxPassportNumber.Text; }
            set { textBoxPassportNumber.Text = value; }
        }

        public string IssuedBy {
            get { return textBoxIssuedBy.Text; }
            set { textBoxIssuedBy.Text = value; }
        }

        public DateTime IssueDate
        {
            get { return dateTimePickerIssueDate.Value; }
            set { dateTimePickerIssueDate.Value = value; }
        }

        public string RegistrationAddress
        {
            get { return textBoxRegistrationAddress.Text; }
            set {  textBoxRegistrationAddress.Text = value; }
        }

        public string ActualAddress
        {
            get { return textBoxActualAddress.Text; }
            set { textBoxActualAddress.Text = value; }
        }

        public string PhoneNumber
        {
            get { return textBoxPhoneNumber.Text; }
            set { textBoxPhoneNumber.Text = value; }
        }

        public string Email
        {
            get { return textBoxEmail.Text; }
            set { textBoxEmail.Text = value; }
        }

        public string Telegram
        {
            get { return textBoxTelegram.Text; }
            set { textBoxTelegram.Text = value; }
        }

        public int PositionId
        {
            get { return Convert.ToInt32(comboBoxPosition.SelectedValue); }
            set { comboBoxPosition.SelectedValue = value; }
        }

        public int LevelId
        {
            get { return Convert.ToInt32(comboBoxLevel.SelectedValue); }
            set { comboBoxLevel.SelectedValue = value; }
        }

        public int SelectedEmployeeSkillId
        {
            get
            {
                int selectedEmployeeSkillId = 0;

                if (dataGridViewEmployeeSkills.Rows.Count > 0)
                {
                    int selectedRowIndex = dataGridViewEmployeeSkills.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewEmployeeSkills.Rows[selectedRowIndex];
                    selectedEmployeeSkillId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                }

                return selectedEmployeeSkillId;
            }
        }

        public bool IsEdit {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler ShowPositionViewEvent;
        public event EventHandler AddEmployeeEvent;
        public event EventHandler EditEmployeeEvent;
        public event EventHandler RemoveEmployeeEvent;
        public event EventHandler ShowLevelViewEvent;
        public event EventHandler AddEmployeeSkillEvent;
        public event EventHandler RemoveEmployeeSkillEvent;
        public event EventHandler SaveChangesEvent;
        public event EventHandler CancelChangesEvent;

        public EmployeeView()
        {
            InitializeComponent();
            AssociateControlEventsWithViewEvents();
        }

        private void AssociateControlEventsWithViewEvents()
        {
            buttonAddEmployee.Click += ButtonAddEmployeeClicked;
            buttonEditEmployee.Click += ButtonEditEmployeeClicked;
            buttonRemoveEmployee.Click += ButtonRemoveEmployeeClicked;
            buttonShowEmployeeDetails.Click += ButtonShowEmployeeDetailsClicked;
            buttonHideEmployeeDetails.Click += ButtonHideEmployeeDetailsClicked;
            buttonOK.Click += ButtonOKClicked;
            buttonCancel.Click += ButtonCancelClicked;
            buttonShowPositionView.Click += ButtonShowPositionViewClicked;
            buttonShowLevelView.Click += ButtonShowLevelViewClicked;
            buttonAddEmployeeSkill.Click += ButtonAddEmployeeSkillClicked;
            buttonRemoveEmployeeSkill.Click += ButtonRemoveEmployeeSkillClicked;
        }

        private void ButtonAddEmployeeClicked(object sender, EventArgs e)
        {
            dataGridViewEmployees.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            AddEmployeeEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEditEmployeeClicked(object sender, EventArgs e)
        {
            if (SelectedEmployeeId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToUpdate, Resources.CaptionUpdate,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            dataGridViewEmployees.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            EditEmployeeEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonRemoveEmployeeClicked(object sender, EventArgs e)
        {
            if (SelectedEmployeeId == 0)
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
                    RemoveEmployeeEvent?.Invoke(this, EventArgs.Empty);
                    
                    MessageBox.Show(
                        Message, Resources.CaptionDelete,
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void ButtonShowEmployeeDetailsClicked(object sender, EventArgs e)
        {
            if (SelectedEmployeeId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToView, Resources.CaptionDetails,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }

            dataGridViewEmployees.Visible = false;
            panelDetailsForm.Visible = true;
            ToggleActionButtons(false);

            int selectedRowIndex = dataGridViewEmployees.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewEmployees.Rows[selectedRowIndex];

            lastNameDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[1].Value);
            firstNameDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[2].Value);
            middleNameDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[3].Value);
            birthDateDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[4].Value);
            passportSeriesDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[5].Value);
            passportNumberDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[6].Value);
            issuedByDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[7].Value);
            issueDateDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[8].Value);
            registrationAddressDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[9].Value);
            actualAddressDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[10].Value);
            phoneNumberDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[11].Value);
            emailDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[12].Value);
            telegramDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[13].Value);
            positionDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[15].Value);
            levelDetails.Text = PrepareDataGridViewCellValueToShow(selectedRow.Cells[17].Value);
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
                    dataGridViewEmployees.Visible = true;
                    panelEditForm.Visible = false;
                    ToggleActionButtons(true);

                    if (!isEdit && dataGridViewEmployees.Rows.Count > 0)
                    {
                        dataGridViewEmployees.Rows[dataGridViewEmployees.RowCount - 1].Selected = true;
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
            dataGridViewEmployees.Visible = true;
            panelEditForm.Visible = false;
            ToggleActionButtons(true);

            CancelChangesEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonShowPositionViewClicked(object sender, EventArgs e)
        {
            ShowPositionViewEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonShowLevelViewClicked(object sender, EventArgs e)
        {
            ShowLevelViewEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonAddEmployeeSkillClicked(object sender, EventArgs e)
        {
            AddEmployeeSkillEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonRemoveEmployeeSkillClicked(object sender, EventArgs e)
        {
            if (SelectedEmployeeSkillId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToDelete, Resources.CaptionDelete,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            RemoveEmployeeSkillEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonHideEmployeeDetailsClicked(object sender, EventArgs e)
        {
            dataGridViewEmployees.Visible = true;
            panelDetailsForm.Visible = false;
            ToggleActionButtons(true);
        }

        public void FillDataGridViewEmployees(DataTable employeeDataTable)
        {
            dataGridViewEmployees.DataSource = employeeDataTable;
            dataGridViewEmployees.Columns[0].Visible = false;
            dataGridViewEmployees.Columns[14].Visible = false;
            dataGridViewEmployees.Columns[16].Visible = false;
        }

        public void FillComboBoxPositions(DataTable positionDataTable)
        {
            comboBoxPosition.DataSource = positionDataTable;
            comboBoxPosition.ValueMember = positionDataTable.Columns[0].ColumnName;
            comboBoxPosition.DisplayMember = positionDataTable.Columns[1].ColumnName;
        }

        public void FillComboBoxLevels(DataTable levelDataTable)
        {
            comboBoxLevel.DataSource = levelDataTable;
            Console.WriteLine(levelDataTable.Columns[0].ColumnName);
            comboBoxLevel.ValueMember = levelDataTable.Columns[0].ColumnName;
            comboBoxLevel.DisplayMember = levelDataTable.Columns[1].ColumnName;
        }

        public void FillDataGridViewEmployeeSkills(DataTable employeeSkillDataTable)
        {
            dataGridViewEmployeeSkills.DataSource = employeeSkillDataTable;
        }

        private void ToggleActionButtons(bool enabled)
        {
            buttonAddEmployee.Enabled = enabled;
            buttonEditEmployee.Enabled = enabled;
            buttonRemoveEmployee.Enabled = enabled;
            buttonShowEmployeeDetails.Enabled = enabled;
        }

        private string PrepareDataGridViewCellValueToShow(object value)
        {
            if (value.ToString() == string.Empty)
            {
                return "—";
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
