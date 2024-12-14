namespace HumanResourcesSystem.Views
{
    partial class SkillView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonRemoveSkill = new System.Windows.Forms.Button();
            this.buttonEditSkill = new System.Windows.Forms.Button();
            this.buttonAddSkill = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelEditForm = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewSkills = new System.Windows.Forms.DataGridView();
            this.panelEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(13, 13);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(57, 16);
            this.labelHeader.TabIndex = 37;
            this.labelHeader.Text = "Навыки";
            // 
            // buttonRemoveSkill
            // 
            this.buttonRemoveSkill.Location = new System.Drawing.Point(396, 122);
            this.buttonRemoveSkill.Name = "buttonRemoveSkill";
            this.buttonRemoveSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveSkill.TabIndex = 35;
            this.buttonRemoveSkill.Text = "Удалить";
            this.buttonRemoveSkill.UseVisualStyleBackColor = true;
            // 
            // buttonEditSkill
            // 
            this.buttonEditSkill.Location = new System.Drawing.Point(396, 64);
            this.buttonEditSkill.Name = "buttonEditSkill";
            this.buttonEditSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonEditSkill.TabIndex = 34;
            this.buttonEditSkill.Text = "Изменить";
            this.buttonEditSkill.UseVisualStyleBackColor = true;
            // 
            // buttonAddSkill
            // 
            this.buttonAddSkill.Location = new System.Drawing.Point(396, 36);
            this.buttonAddSkill.Name = "buttonAddSkill";
            this.buttonAddSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSkill.TabIndex = 33;
            this.buttonAddSkill.Text = "Добавить";
            this.buttonAddSkill.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(204, 84);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(12, 27);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(348, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(285, 84);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // panelEditForm
            // 
            this.panelEditForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEditForm.Controls.Add(this.labelName);
            this.panelEditForm.Controls.Add(this.buttonCancel);
            this.panelEditForm.Controls.Add(this.textBoxName);
            this.panelEditForm.Controls.Add(this.buttonOK);
            this.panelEditForm.Location = new System.Drawing.Point(16, 36);
            this.panelEditForm.Name = "panelEditForm";
            this.panelEditForm.Padding = new System.Windows.Forms.Padding(6);
            this.panelEditForm.Size = new System.Drawing.Size(376, 120);
            this.panelEditForm.TabIndex = 36;
            this.panelEditForm.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 12);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Наименование";
            // 
            // dataGridViewSkills
            // 
            this.dataGridViewSkills.AllowUserToAddRows = false;
            this.dataGridViewSkills.AllowUserToDeleteRows = false;
            this.dataGridViewSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkills.Location = new System.Drawing.Point(16, 36);
            this.dataGridViewSkills.MultiSelect = false;
            this.dataGridViewSkills.Name = "dataGridViewSkills";
            this.dataGridViewSkills.ReadOnly = true;
            this.dataGridViewSkills.RowHeadersVisible = false;
            this.dataGridViewSkills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSkills.Size = new System.Drawing.Size(374, 410);
            this.dataGridViewSkills.TabIndex = 32;
            // 
            // SkillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 460);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonRemoveSkill);
            this.Controls.Add(this.buttonEditSkill);
            this.Controls.Add(this.buttonAddSkill);
            this.Controls.Add(this.panelEditForm);
            this.Controls.Add(this.dataGridViewSkills);
            this.Name = "SkillView";
            this.Text = "Справочник «Навыки»";
            this.panelEditForm.ResumeLayout(false);
            this.panelEditForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonRemoveSkill;
        private System.Windows.Forms.Button buttonEditSkill;
        private System.Windows.Forms.Button buttonAddSkill;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelEditForm;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewSkills;
    }
}