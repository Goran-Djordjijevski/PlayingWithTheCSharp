using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        IList<float> grades;

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
    }
}
