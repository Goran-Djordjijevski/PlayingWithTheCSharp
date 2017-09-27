using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            this.HighestGrade = 0;
            this.LowestGrade = float.MaxValue;
        }

        public float AverageGrade { get; set; }
        public float HighestGrade { get; set; }
        public float LowestGrade { get; set; }
    }
}
