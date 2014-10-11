using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsd311_SemesterProject
{
    public class CogSci : Study
    {
        private Course[] _requiredCourses;
        private const int _mathSciCourses = 2;
        private const int _coreCourses = 6;
        private const int _generalCourses = 4;
        private const int _commCourses = 2;

        public CogSci()
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

            return "CogSci";
        }
        
    }
}
