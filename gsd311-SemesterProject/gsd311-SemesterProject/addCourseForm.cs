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
    public partial class addCourseForm : Form
    {
        //Globals
        DBM database1 = new DBM();
        Course[] tempCourses;
        Course selectedCourse;
        double grade;
        DataTable dt1 = new DataTable();
        DataColumn dc1 = new DataColumn("CourseName");
        DataColumn dc2 = new DataColumn("CourseType");
        DataColumn dc3 = new DataColumn("CreditHours");
        

        public addCourseForm()
        {
            InitializeComponent();
            populateCourseCB();
            cbCourseName.SelectedIndex = 0;
            txtCourseType.Text = "MathSci";
            txtCreditHours.Text = "4";

        }

        private void addCourseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool success = false;
            success = double.TryParse(txtGrade.Text, out grade);
            if ((!success) || (grade < 0 || grade > 4))
            {
                MessageBox.Show("Enter Valid Grade!");
            }
            else
            {
                selectedCourse.GPA = grade;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            
            
        }

        private void cbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex;
            currentIndex = cbCourseName.SelectedIndex;
            txtCourseType.Text = cbCourseName.SelectedValue.ToString();
            txtCreditHours.Text = (string)dt1.Rows[currentIndex]["CreditHours"];
            selectedCourse = tempCourses[currentIndex];

        }

        private void populateCourseCB()
        {
            dt1.Columns.Add(dc1);
            dt1.Columns.Add(dc2);
            dt1.Columns.Add(dc3);
            
            tempCourses = database1.getAllCourses();
            

            foreach (Course tempCourse in tempCourses)
            {
                string courseType;
                if (tempCourse is MathSci)
                {
                    courseType = "MathSci";
                }
                else if (tempCourse is Core)
                {
                    courseType = "Core";
                }
                else if (tempCourse is General)
                {
                    courseType = "General";
                }
                else
                {
                    courseType = "Communication";
                }
                dt1.Rows.Add(tempCourse.CourseName, courseType, tempCourse.CreditHours);
            }

            cbCourseName.DataSource = dt1;
            cbCourseName.DisplayMember = "CourseName";
            cbCourseName.ValueMember = "CourseType";

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            bool success = false;
            success = double.TryParse(txtGrade.Text, out grade);
            if ((!success) || (grade < 0 || grade > 4))
            {
                MessageBox.Show("Enter Valid Grade!");
            }


        }

        public Course returnCourseData(){
            return selectedCourse;
        }
    }
}
