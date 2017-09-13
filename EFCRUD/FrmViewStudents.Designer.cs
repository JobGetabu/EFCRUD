namespace EFCRUD
{
    partial class FrmViewStudents
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
            this.metroBtnDel = new MetroFramework.Controls.MetroButton();
            this.dataGridViewStuds = new System.Windows.Forms.DataGridView();
            this.adminNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroBtnEdit = new MetroFramework.Controls.MetroButton();
            this.metroBtnAdd = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStuds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsStudentInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroBtnDel
            // 
            this.metroBtnDel.Location = new System.Drawing.Point(473, 387);
            this.metroBtnDel.Name = "metroBtnDel";
            this.metroBtnDel.Size = new System.Drawing.Size(75, 23);
            this.metroBtnDel.TabIndex = 0;
            this.metroBtnDel.Text = "Delete";
            this.metroBtnDel.Click += new System.EventHandler(this.metroBtnDel_Click);
            // 
            // dataGridViewStuds
            // 
            this.dataGridViewStuds.AutoGenerateColumns = false;
            this.dataGridViewStuds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStuds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminNoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.formDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridViewStuds.DataSource = this.studentsStudentInfoBindingSource;
            this.dataGridViewStuds.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewStuds.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewStuds.Name = "dataGridViewStuds";
            this.dataGridViewStuds.Size = new System.Drawing.Size(540, 321);
            this.dataGridViewStuds.TabIndex = 1;
            // 
            // adminNoDataGridViewTextBoxColumn
            // 
            this.adminNoDataGridViewTextBoxColumn.DataPropertyName = "Admin_No";
            this.adminNoDataGridViewTextBoxColumn.HeaderText = "Admin No";
            this.adminNoDataGridViewTextBoxColumn.Name = "adminNoDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // formDataGridViewTextBoxColumn
            // 
            this.formDataGridViewTextBoxColumn.DataPropertyName = "Form";
            this.formDataGridViewTextBoxColumn.HeaderText = "Form";
            this.formDataGridViewTextBoxColumn.Name = "formDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // studentsStudentInfoBindingSource
            // 
            this.studentsStudentInfoBindingSource.DataSource = typeof(EFCRUD.Students_StudentInfo);
            // 
            // metroBtnEdit
            // 
            this.metroBtnEdit.Location = new System.Drawing.Point(383, 387);
            this.metroBtnEdit.Name = "metroBtnEdit";
            this.metroBtnEdit.Size = new System.Drawing.Size(75, 23);
            this.metroBtnEdit.TabIndex = 2;
            this.metroBtnEdit.Text = "Edit";
            this.metroBtnEdit.Click += new System.EventHandler(this.metroBtnEdit_Click);
            // 
            // metroBtnAdd
            // 
            this.metroBtnAdd.Location = new System.Drawing.Point(290, 387);
            this.metroBtnAdd.Name = "metroBtnAdd";
            this.metroBtnAdd.Size = new System.Drawing.Size(75, 23);
            this.metroBtnAdd.TabIndex = 3;
            this.metroBtnAdd.Text = "Add";
            this.metroBtnAdd.Click += new System.EventHandler(this.metroBtnAdd_Click);
            // 
            // FrmViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 427);
            this.Controls.Add(this.metroBtnAdd);
            this.Controls.Add(this.metroBtnEdit);
            this.Controls.Add(this.dataGridViewStuds);
            this.Controls.Add(this.metroBtnDel);
            this.Name = "FrmViewStudents";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.FrmViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStuds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsStudentInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroBtnDel;
        private System.Windows.Forms.DataGridView dataGridViewStuds;
        private MetroFramework.Controls.MetroButton metroBtnEdit;
        private MetroFramework.Controls.MetroButton metroBtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsStudentInfoBindingSource;
    }
}