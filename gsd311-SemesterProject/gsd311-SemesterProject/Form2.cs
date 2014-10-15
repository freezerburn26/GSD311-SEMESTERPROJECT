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
    public partial class Form2 : Form
    {
        //globals
        addCourseForm newCoursefrm;
        Student selectedStudent;
        DBM database1 = new DBM();
        bool somethingChanged = false;

        //OriginalConstructor
        //public Form2()
        //{
        //    InitializeComponent();
        //}

        public Form2(Student tempStudent)
        {
            InitializeComponent();
            selectedStudent = tempStudent;
            if (selectedStudent.APStudy.ToString().Equals("CompSci"))
            {
                cbStudy.SelectedIndex = 0;
            }
            if (selectedStudent.APStudy.ToString().Equals("CogSci"))
            {
                cbStudy.SelectedIndex = 1;
            }
            if (selectedStudent.APStudy.ToString().Equals("MatEng"))
            {
                cbStudy.SelectedIndex = 2;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //initialize DGVCourses
            writeCousesDGV();
            

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            if (somethingChanged)
            {
                database1.updateStudentInfo(selectedStudent);
            }
        }

        private void cbStudy_SelectedIndexChanged(object sender, EventArgs e)
        {
            somethingChanged = true;
            if (cbStudy.Text == "MatEng")
            {
                selectedStudent.setAPStudy("MatEng");
            }
            if (cbStudy.Text == "CompSci")
            {
                selectedStudent.setAPStudy("CompSci");
            }
            if (cbStudy.Text == "CogSci")
            {
                selectedStudent.setAPStudy("CogSci");
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            somethingChanged = true;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            somethingChanged = true;
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            somethingChanged = true;
            dgvCourses.Rows.RemoveAt(dgvCourses.CurrentCell.RowIndex);
            selectedStudent.removeCourseAtIndex(dgvCourses.CurrentCell.RowIndex);
        }

        private void writeCousesDGV()
        {
            dgvCourses.Rows.Clear();
            decimal tempGPA2;
            selectedStudent.calcGPA();
            selectedStudent.eligibleForStudy(selectedStudent.APStudy);

            Course[] tempCourses = selectedStudent.getCourseList().ToArray();
            foreach (Course temp in tempCourses)
            {
                string type = null;
                if (temp is MathSci)
                {
                    type = "MathSci";
                }
                if (temp is Communication)
                {
                    type = "Communication";
                }
                if (temp is Core)
                {
                    type = "Core";
                }
                if (temp is General)
                {
                    type = "General";
                }
                tempGPA2 = (decimal)temp.GPA;
                dgvCourses.Rows.Add(temp.CourseName, temp.GPA.ToString("F1"), temp.CreditHours, type);
            }

            tempGPA2 = (decimal)selectedStudent.GPA;
            GPA.Text = tempGPA2.ToString("F1");
            txtEligible.Text = selectedStudent.Eligable.ToString();
            txtCreditHours.Text = selectedStudent.CreditHours.ToString();
            txtFirstName.Text = selectedStudent.FirstName;
            txtLastName.Text = selectedStudent.LastName;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            somethingChanged = true;
            newCoursefrm = new addCourseForm();
            newCoursefrm.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = newCoursefrm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                newCoursefrm.Close();
                //MessageBox.Show("Canceled!");
            }
            else if (dr == DialogResult.OK)
            {
                
                selectedStudent.addCourse(newCoursefrm.returnCourseData());
                newCoursefrm.Close();
                //MessageBox.Show("Success!");
                writeCousesDGV();
            }
        }
    }
}
