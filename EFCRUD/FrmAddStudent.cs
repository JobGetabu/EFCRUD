using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCRUD
{
    public partial class FrmAddStudent : MetroFramework.Forms.MetroForm
    {

        StudentsEntities context;
        public FrmAddStudent(Students_StudentInfo obj)
        {
            InitializeComponent();
            context = new StudentsEntities();
            //check if student object is null
            //initialize the studentstudentInfoBindingSource

            if (obj == null)
            {
                studentsStudentInfoBindingSource.DataSource = new Students_StudentInfo();
                context.Students_StudentInfo.Add(studentsStudentInfoBindingSource.Current as Students_StudentInfo);
            }
            else
            {
                studentsStudentInfoBindingSource.DataSource = obj;
                context.Students_StudentInfo.Attach(studentsStudentInfoBindingSource.Current as Students_StudentInfo);
                context.SaveChanges();
            }
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            context = new StudentsEntities();
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroTextBoxAdminNo.Text = "";
            metroTextBoxFName.Text = "";
            metroTextBoxLName.Text = "";
            metroTextBoxClass.Text = "";
            metroTextBoxForm.Text = "";
        }

        private void searchThroughDb(bool duplicate, StudentsEntities context, Students_StudentInfo obj)
        {
            var query = from s in context.Students_StudentInfo
                        select s;
            foreach (var student in query)
            {
                if (obj.Admin_No == student.Admin_No)
                {
                    MessageBox.Show(this, "Cannot add duplicate student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    duplicate = true;
                    break;
                }
            }
        }


        //TODO
        //Look for algorithmn to cancel a click event
        //Look for algorithm to properly look up an implemented event 
        private void metroBtnSave_Click(object sender, EventArgs e)
        {
                context.Students_StudentInfo.Add(studentsStudentInfoBindingSource.Current as Students_StudentInfo);

                if (!FrmViewStudents.isEditButton)
                {
                    searchThroughDb(false, context, studentsStudentInfoBindingSource.Current as Students_StudentInfo);
                }
                else
                {
                    context.Entry<Students_StudentInfo>(studentsStudentInfoBindingSource.Current as Students_StudentInfo).State = System.Data.Entity.EntityState.Modified;

                //still a problem in checking for duplicate records in edit function
                //admin no are still not verified if exists
                }

                //running this any way still saves duplicate records in the database
                context.SaveChanges();
        }

        private void FrmAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (DialogResult == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(metroTextBoxAdminNo.Text) && string.IsNullOrEmpty(metroTextBoxFName.Text) && string.IsNullOrEmpty(metroTextBoxLName.Text) && string.IsNullOrEmpty(metroTextBoxForm.Text))
                    {
                        MessageBox.Show(this, "Please fill missing information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                    context.SaveChanges();
                    e.Cancel = false;
                }
                e.Cancel = false;
            }
    }
}
