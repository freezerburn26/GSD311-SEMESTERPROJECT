﻿using AdvanceProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsd311_SemesterProject
{
    public class Student : IStudent
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
        public string ReasonIneligable = "";
        private string _SSN;
        List<ICourse> icourses = new List<ICourse>();



        public Student()
        {

        }

        public Student(string FirstName, string LastName, string SSN)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _SSN = SSN;
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
            ReasonIneligable = "";
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
                ReasonIneligable += " GPA too low. ";
                _eligable = false;
            }
            else if (_creditHours < 50)
            {
                ReasonIneligable += " Not Enough Credit Hours. ";
                _eligable = false;
            }
            else if (checkStudy.MathSciCourses > _mathSciCourses)
            {
                ReasonIneligable += " Not Enough MathSci Courses. ";
                _eligable = false;
            }
            else if (checkStudy.CommCourses > _commCourses)
            {
                ReasonIneligable += " Not Enough Communication Courses. ";
                _eligable = false;
            }
            else if (checkStudy.CoreCourses > _coreCourses)
            {
                ReasonIneligable += " Not Enough Core Courses. ";
                _eligable = false;
            }
            else if (checkStudy.GeneralCourses > _genCourses)
            {
                ReasonIneligable += " Not Enough General Courses. ";
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

            for (int i = 0; i < tempCourses.Length; i++)
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

        public List<Course> GetCourseList()
        {
            return _courses;
        }

        public void RemoveCourseAtIndex(int index)
        {
            _courses.RemoveAt(index);
        }



        public List<ICourse> CourseList()
        {
            icourses = new List<ICourse>();

            foreach (var course in _courses)
            {
                icourses.Add(course);
            }
            return icourses;
        }

        public string Print(PrintType printSelection)
        {
            double tempGPA = 0;
            int count = 0;
            double sum = 0;
            foreach (Course icourse in icourses)
            {
                sum += icourse.GPA;
                count++;
            }
            tempGPA = sum / count;

            string temp;
            if (printSelection == PrintType.ShortView)
            {
                temp = string.Join(",", _firstName, _lastName);
                return temp;
            }
            else if (printSelection == PrintType.StudentView)
            {
                temp = string.Join(",", _firstName, _lastName, _SSN, tempGPA);
                return temp;
            }
            else
            {

                temp = string.Join(",", _firstName, _lastName, _SSN, tempGPA);
                temp += ",";
                foreach (Course icourse in icourses)
                {
                    temp += Environment.NewLine + icourse.CourseName + "," + icourse.GPA;
                }
                return temp;
            }
        }

        public void appendCourses(List<ICourse> courses)
        {
            foreach (var course in courses)
            {
                icourses.Add(course);
            }
        }
    }
}
