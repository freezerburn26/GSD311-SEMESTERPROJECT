using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsd311_SemesterProject
{
    public class Student
    {
        private int _studentId;
        private string _studentNum;
        private double _GPA;
        private int _creditHours;
        private string _firstName;
        private string _lastName;
        private Study _apStudy;
        private bool _eligable;
        private List<Course> _courses = new List<Course>();
        private int _mathSciCourses;
        private int _coreCourses;
        private int _commCourses;
        private int _genCourses;


        public Student()
        {

        }

        public int StudentId
        {
            get
            {
                return this._studentId;
            }
            set
            {
                this._studentId = value;
            }
        }

        public string StudentNum
        {
            get
            {
                return this._studentNum;
            }
            set
            {
                this._studentNum = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }

        public double GPA
        {
            get
            {
                this.calcGPA();
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

        public Study APStudy
        {
            get
            {
                return this._apStudy;
            }
        }

        public void setAPStudy(string x)
        {
            Study temp = new CompSci();
            if (x.Equals("CompSci"))
            {
                temp = new CompSci();
            }
            else if (x.Equals("CogSci"))
            {
                temp = new CogSci();
            }
            else if (x.Equals("MatEng"))
            {
                temp = new MatEng();
            }

            this._apStudy = temp;
        }

        public bool Eligable
        {
            get
            {
                this.eligibleForStudy(_apStudy);
                return this._eligable;
            }
            set
            {
                this._eligable = value;
            }
        }

        public void addCourse(Course newCourse)
        {
            _courses.Add(newCourse);
            this.calcGPA();
            this.eligibleForStudy(this._apStudy);
        }

        public void removeCourse(Course newCourse)
        {
            _courses.Remove(newCourse);
        }

        public void eligibleForStudy(Study checkStudy)
        {
            Course[] nCourses = _courses.ToArray();
            _creditHours = 0;
            _commCourses = 0;
            _coreCourses = 0;
            _genCourses = 0;
            _mathSciCourses = 0;
            for (int i = 0; i < nCourses.Length; i++)
            {
                _creditHours += nCourses[i].CreditHours;

                if (nCourses[i] is Communication)
                {
                    _commCourses++;
                }
                if (nCourses[i] is Core)
                {
                    _coreCourses++;
                }
                if (nCourses[i] is MathSci)
                {
                    _mathSciCourses++;
                }
                if (nCourses[i] is General)
                {
                    _genCourses++;
                }
            }


            if (_GPA < 3.5)
            {
                _eligable = false;
            }
            else if (_creditHours < 50)
            {
                _eligable = false;
            }
            else if(checkStudy.MathSciCourses > _mathSciCourses)
            {
                _eligable = false;
            }
            else if (checkStudy.CommCourses > _commCourses)
            {
                _eligable = false;
            }
            else if (checkStudy.CoreCourses > _coreCourses)
            {
                _eligable = false;
            }
            else if (checkStudy.GeneralCourses > _genCourses)
            {
                _eligable = false;
            }
            else
            {
                _eligable = true;
            }

        }

        public void calcGPA()
        {
            double temp = 0;
            double totalCH = 0;
            double tempCalc = 0;
            Course[] tempCourses = _courses.ToArray();

            for(int i = 0; i < tempCourses.Length; i++)
            {
                totalCH += tempCourses[i].CreditHours;
                tempCalc += (tempCourses[i].CreditHours * tempCourses[i].GPA);
            }
            if (totalCH > 0)
            {
                temp = tempCalc / totalCH;
            }
            
            this._GPA = temp;
        }

        public List<Course> getCourseList()
        {
            return _courses;
        }

        public void removeCourseAtIndex(int index)
        {
            _courses.RemoveAt(index);
        }


    }
}
