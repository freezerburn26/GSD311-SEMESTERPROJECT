using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsd311_SemesterProject
{
    public class MatEng : Study
    {
        private Course[] _requiredCourses;
        private const int _mathSciCourses = 6;
        private const int _coreCourses = 2;
        private const int _generalCourses = 6;
        private const int _commCourses = 0;

        public MatEng()
        {

        }

        public Course[] RequiredCourses
        {
            get
            {
                return this._requiredCourses;
            }
            
        }

        public override int MathSciCourses
        {
            get
            {
                return _mathSciCourses;
            }
            
        }

        public override int CoreCourses
        {
            get
            {
                return _coreCourses;
            }
            
        }

        public override int GeneralCourses
        {
            get
            {
                return _generalCourses;
            }
           
        }

        public override int CommCourses
        {
            get
            {
                return _commCourses;
            }
            
        }

        public override string ToString()
        {

            return "MatEng";
        }
    }
}
