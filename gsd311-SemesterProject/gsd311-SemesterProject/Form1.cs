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
        //Globals
        Form2 editStudentForm;
        addNewStudent addStudentFrm;
        List<Student> studentList = new List<Student>();
        DBM sqldatabase = new DBM();
        Student selectedStudent;
        Student newStudent;
        
        


        public Form1()
        {
            InitializeComponent();
            
            //initialize students into list
            initializeStudents();
            
            //Select first student
            selectedStudent = studentList.ElementAt(0);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Write DataGridView
            writeStudentDGV();
            
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tempInt = 0;
            tempInt = dgvStudents.CurrentCell.RowIndex;
            selectedStudent = studentList.ElementAt(tempInt);
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            editStudentForm = new Form2(selectedStudent);
            editStudentForm.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = editStudentForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                editStudentForm.Close();
                //MessageBox.Show("Canceled!");
                //MessageBox.Show("Restart Program to clear added Courses from Student");
            }
            else if (dr == DialogResult.OK)
            {
                writeStudentDGV();
                editStudentForm.Close();
                //MessageBox.Show("Success!");
            }
        }

        public void initializeStudents()
        {
            Student[] tempStudents;
            tempStudents = sqldatabase.getStudentInfo();
            foreach (Student tempStudent in tempStudents)
            {
                studentList.Add(tempStudent);
            }
        }

        public void writeStudentDGV()
        {
            dgvStudents.Rows.Clear();

            foreach (Student tempStudent in studentList)
            {
                decimal tempGPA2;
                tempGPA2 = (decimal)tempStudent.GPA;
                dgvStudents.Rows.Add(tempStudent.FirstName + " " + tempStudent.LastName, tempGPA2.ToString("F1"), tempStudent.APStudy, tempStudent.StudentNum, tempStudent.Eligable);

            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            addStudentFrm = new addNewStudent();
            addStudentFrm.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = addStudentFrm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                addStudentFrm.Close();
                //MessageBox.Show("Canceled!");
                
            }
            else if (dr == DialogResult.OK)
            {
                newStudent = addStudentFrm.returnNewStudent();
                studentList.Add(newStudent);
                writeStudentDGV();
                addStudentFrm.Close();
                //MessageBox.Show("Success!");
            }

        }
    }
}
