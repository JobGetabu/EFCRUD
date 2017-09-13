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
        public FrmAddStudent(Students_StudentInfo obj)
        {
            InitializeComponent();

            //check if student object is null
            //initialize the studentstudentInfoBindingSource

            using(var context = new StudentsEntities())
            {
                if (obj == null)
                {
                    studentsStudentInfoBindingSource.DataSource = new Students_StudentInfo();
                    context.Students_StudentInfo.Add(studentsStudentInfoBindingSource.Current as Students_StudentInfo);
                }
                else
                {
                    studentsStudentInfoBindingSource.DataSource = obj;

                    var studObj = studentsStudentInfoBindingSource.Current as Students_StudentInfo;
                    context.Students_StudentInfo.Attach(studObj);
                    context.SaveChanges();
                }
               
            }
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroTextBoxAdminNo.Text = "";
            metroTextBoxFName.Text = "";
            metroTextBoxLName.Text = "";
            metroTextBoxClass.Text = "";
            metroTextBoxForm.Text="";
        }

        private void metroBtnSave_Click(object sender, EventArgs e)
        {
            using (var context = new StudentsEntities())
            {
                var studObj = studentsStudentInfoBindingSource.Current as Students_StudentInfo;
                context.Students_StudentInfo.Add(studObj);

                if (!FrmViewStudents.isEditButton)
                {
                    bool duplicate = false;
                    var query = from s in context.Students_StudentInfo
                                select s;

                    foreach (var student in query)
                    {
                        if (studObj.Admin_No == student.Admin_No)
                        {
                            MessageBox.Show(this, "Cannot add duplicate student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            duplicate = true;
                        }
                    }
                    if (!duplicate)
                    {
                        context.SaveChanges();
                        metroButtonClear_Click(sender, e);
                    }
                    duplicate = false;
                }
            }
        }

        private void FrmAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            //studentsStudentInfoBindingSource.DataSource = null;
            
        }

        private void FrmAddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
