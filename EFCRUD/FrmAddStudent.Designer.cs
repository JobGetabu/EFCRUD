namespace EFCRUD
{
    partial class FrmAddStudent
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroBtnSave = new MetroFramework.Controls.MetroButton();
            this.metroTxtBoxId = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxAdminNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxForm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxClass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.studentsStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentsStudentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(77, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id :";
            // 
            // metroBtnSave
            // 
            this.metroBtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.metroBtnSave.Location = new System.Drawing.Point(303, 295);
            this.metroBtnSave.Name = "metroBtnSave";
            this.metroBtnSave.Size = new System.Drawing.Size(75, 23);
            this.metroBtnSave.TabIndex = 6;
            this.metroBtnSave.Text = "Save";
            this.metroBtnSave.Click += new System.EventHandler(this.metroBtnSave_Click);
            // 
            // metroTxtBoxId
            // 
            this.metroTxtBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsStudentInfoBindingSource, "Id", true));
            this.metroTxtBoxId.Enabled = false;
            this.metroTxtBoxId.Location = new System.Drawing.Point(119, 73);
            this.metroTxtBoxId.Name = "metroTxtBoxId";
            this.metroTxtBoxId.Size = new System.Drawing.Size(259, 23);
            this.metroTxtBoxId.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtBoxId.TabIndex = 0;
            // 
            // metroTextBoxAdminNo
            // 
            this.metroTextBoxAdminNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsStudentInfoBindingSource, "Admin_No", true));
            this.metroTextBoxAdminNo.Location = new System.Drawing.Point(119, 105);
            this.metroTextBoxAdminNo.Name = "metroTextBoxAdminNo";
            this.metroTextBoxAdminNo.Size = new System.Drawing.Size(259, 23);
            this.metroTextBoxAdminNo.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxAdminNo.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Admin No:";
            // 
            // metroTextBoxFName
            // 
            this.metroTextBoxFName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsStudentInfoBindingSource, "First_Name", true));
            this.metroTextBoxFName.Location = new System.Drawing.Point(119, 149);
            this.metroTextBoxFName.Name = "metroTextBoxFName";
            this.metroTextBoxFName.Size = new System.Drawing.Size(259, 23);
            this.metroTextBoxFName.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFName.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "First Name :";
            // 
            // metroTextBoxLName
            // 
            this.metroTextBoxLName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsStudentInfoBindingSource, "Last_Name", true));
            this.metroTextBoxLName.Location = new System.Drawing.Point(119, 181);
            this.metroTextBoxLName.Name = "metroTextBoxLName";
            this.metroTextBoxLName.Size = new System.Drawing.Size(259, 23);
            this.metroTextBoxLName.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLName.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 185);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Last Name :";
            // 
            // metroTextBoxForm
            // 
            this.metroTextBoxForm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsStudentInfoBindingSource, "Form", true));
            this.metroTextBoxForm.Location = new System.Drawing.Point(119, 223);
            this.metroTextBoxForm.Name = "metroTextBoxForm";
            this.metroTextBoxForm.Size = new System.Drawing.Size(259, 23);
            this.metroTextBoxForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxForm.TabIndex = 4;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 227);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Form :";
            // 
            // metroTextBoxClass
            // 
            this.metroTextBoxClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsStudentInfoBindingSource, "Class", true));
            this.metroTextBoxClass.Location = new System.Drawing.Point(119, 252);
            this.metroTextBoxClass.Name = "metroTextBoxClass";
            this.metroTextBoxClass.Size = new System.Drawing.Size(259, 23);
            this.metroTextBoxClass.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxClass.TabIndex = 5;
            this.metroTextBoxClass.Tag = "i.e North or South";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(66, 256);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Class :";
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(208, 295);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(75, 23);
            this.metroButtonClear.TabIndex = 14;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // studentsStudentInfoBindingSource
            // 
            this.studentsStudentInfoBindingSource.DataSource = typeof(EFCRUD.Students_StudentInfo);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 348);
            this.Controls.Add(this.metroButtonClear);
            this.Controls.Add(this.metroTextBoxClass);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTextBoxForm);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBoxLName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxFName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBoxAdminNo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTxtBoxId);
            this.Controls.Add(this.metroBtnSave);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "FrmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddStudent_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsStudentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroBtnSave;
        private MetroFramework.Controls.MetroTextBox metroTxtBoxId;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdminNo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxForm;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxClass;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private System.Windows.Forms.BindingSource studentsStudentInfoBindingSource;
    }
}