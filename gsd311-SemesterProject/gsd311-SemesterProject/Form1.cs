using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace gsd311_SemesterProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student[] testStudents;
            textBox1.Text = "";
            DBM testDBM = new DBM();
            testStudents = testDBM.getStudentInfo();
            foreach (Student testStudent in testStudents)
            {
                textBox1.Text += testStudent.FirstName;
                textBox1.Text += " " + testStudent.LastName;
                textBox1.Text += " " + testStudent.Eligable;
                textBox1.Text += Environment.NewLine;
                
            }
            textBox1.Text += testDBM.getTotalStudents();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 test = new Form2();
            test.Show();
        }
    }
}
