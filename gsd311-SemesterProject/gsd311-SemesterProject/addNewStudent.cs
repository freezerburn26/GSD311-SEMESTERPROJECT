using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsd311_SemesterProject
{
    public partial class addNewStudent : Form
    {
        //globals
        Student tempStudent;
        DBM database1 = new DBM();
        int lastIdUsed;

        public addNewStudent()
        {
            InitializeComponent();
            tempStudent = new Student();
            tempStudent.setAPStudy("CompSci");
            lastIdUsed = database1.getLastStudentId();
            tempStudent.StudentId = lastIdUsed + 1;
            tempStudent.GPA = 0;
            tempStudent.Eligable = false;


        }

        private void addNewStudent_Load(object sender, EventArgs e)
        {
            cbStudy.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            database1.writeNewStudentInfo(tempStudent);
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            tempStudent.FirstName = txtFName.Text;
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            tempStudent.LastName = txtLName.Text;
        }

        private void cbStudy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempStudyString = "CompSci";
            tempStudyString = cbStudy.Text;
            tempStudent.setAPStudy(tempStudyString);
        }

        public Student returnNewStudent()
        {
            return tempStudent;
        }

        private void txtStudentNum_TextChanged(object sender, EventArgs e)
        {
            tempStudent.StudentNum = txtStudentNum.Text;
        }

        
    }
}
