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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Student[] testStudents;
            Student testStudent;
            DBM test2 = new DBM();
            testStudents = test2.getStudentInfo();
            testStudent = testStudents[0];
            Course[] tempCourses = testStudent.getCourseList().ToArray();
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
                dataGridView1.Rows.Add(temp.CourseName, temp.GPA, temp.CreditHours, type);
            }

            textBox1.Text = testStudent.GPA.ToString();
            textBox2.Text = testStudent.Eligable.ToString();
            textBox3.Text = testStudent.CreditHours.ToString();


        }
    }
}
