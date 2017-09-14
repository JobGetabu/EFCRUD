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
    public partial class FrmViewStudents : MetroFramework.Forms.MetroForm
    {
        public FrmViewStudents()
        {
            InitializeComponent();
        }

        StudentsEntities context;
        private void FrmViewStudents_Load(object sender, EventArgs e)
        {
            context = new StudentsEntities();
            studentsStudentInfoBindingSource.DataSource = context.Students_StudentInfo.ToList();


        }
        public static bool isEditButton;
        private void metroBtnAdd_Click(object sender, EventArgs e)
        {
            

            using (FrmAddStudent frmAddstudent = new FrmAddStudent(null))
            {
                if (frmAddstudent.ShowDialog() == DialogResult.OK)
                {
                    studentsStudentInfoBindingSource.DataSource = context.Students_StudentInfo.ToList();
                    isEditButton = false;
                }
            }

        }


        private void metroBtnEdit_Click(object sender, EventArgs e)
        {
            if (studentsStudentInfoBindingSource.DataSource == null)
            {
                return;
            }
            using (FrmAddStudent frmAddstudent = new FrmAddStudent(studentsStudentInfoBindingSource.Current as Students_StudentInfo))
            {
                if (frmAddstudent.ShowDialog() == DialogResult.OK)
                {
                    studentsStudentInfoBindingSource.DataSource = context.Students_StudentInfo.ToList();
                }
            }
            isEditButton = true;
        }

        private void metroBtnDel_Click(object sender, EventArgs e)
        {

            if (studentsStudentInfoBindingSource.Current != null)
            {

                if (MessageBox.Show("Are you sure you want to delete student record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    // context.Entry<Students_StudentInfo>(studentsStudentInfoBindingSource.Current as Students_StudentInfo).State = System.Data.Entity.EntityState.Added;
                    context.Students_StudentInfo.Remove(studentsStudentInfoBindingSource.Current as Students_StudentInfo);
                    studentsStudentInfoBindingSource.RemoveCurrent();
                    context.SaveChanges();
                }
            }
        }


    }
}
