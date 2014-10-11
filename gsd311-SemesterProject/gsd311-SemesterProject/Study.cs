using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gsd311_SemesterProject
{
    public abstract class Study
    {
        public abstract int MathSciCourses { get; }
        public abstract int CoreCourses { get; }
        public abstract int GeneralCourses { get; }
        public abstract int CommCourses { get; }
    }
}
