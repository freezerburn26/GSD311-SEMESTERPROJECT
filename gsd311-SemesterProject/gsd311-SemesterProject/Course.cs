using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsd311_SemesterProject
{
    public class Course
    {
        private string _courseName;
        private double _GPA;
        private int _creditHours;
        private string _courseNum;

        public string CourseName
        {
            get
            {
                return this._courseName;
            }
            set
            {
                this._courseName = value;
            }
        }

        public double GPA
        {
            get
            {
                return this._GPA;
            }
            set
            {
                this._GPA = value;
            }
        }

        public int CreditHours
        {
            get 
            {
                return this._creditHours;
            }
            set
            {
                this._creditHours = value;
            }
        }

        public string CourseNum
        {
            get
            {
                return this._courseNum;
            }
            set
            {
                this._courseNum = value;
            }
        }

        

    }
}
