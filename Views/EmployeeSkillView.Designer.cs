namespace HumanResourcesSystem.Views
{
    partial class EmployeeSkillView
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
            this.textBoxSkillLevel = new System.Windows.Forms.TextBox();
            this.labelSkillLevel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSkillLevel
            // 
            this.textBoxSkillLevel.Location = new System.Drawing.Point(15, 25);
            this.textBoxSkillLevel.Name = "textBoxSkillLevel";
            this.textBoxSkillLevel.Size = new System.Drawing.Size(150, 20);
            this.textBoxSkillLevel.TabIndex = 0;
            // 
            // labelSkillLevel
            // 
            this.labelSkillLevel.AutoSize = true;
            this.labelSkillLevel.Location = new System.Drawing.Point(12, 9);
            this.labelSkillLevel.Name = "labelSkillLevel";
            this.labelSkillLevel.Size = new System.Drawing.Size(92, 13);
            this.labelSkillLevel.TabIndex = 1;
            this.labelSkillLevel.Text = "Уровень навыка";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(90, 51);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // EmployeeSkillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 83);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelSkillLevel);
            this.Controls.Add(this.textBoxSkillLevel);
            this.Name = "EmployeeSkillView";
            this.Text = "Навык сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSkillLevel;
        private System.Windows.Forms.Label labelSkillLevel;
        private System.Windows.Forms.Button buttonSave;
    }
}