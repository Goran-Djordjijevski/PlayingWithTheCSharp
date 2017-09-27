using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public IList<float> Grades { get; set; }

        public GradeBook()
        {
            Grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics gradeStats = new GradeStatistics();

            float sum = 0;
            foreach (var grade in Grades)
            {
                gradeStats.HighestGrade = Math.Max(grade, gradeStats.HighestGrade);
                gradeStats.LowestGrade = Math.Min(grade, gradeStats.LowestGrade);
                sum += grade;
            }

            gradeStats.AverageGrade = sum / Grades.Count;

            return gradeStats;
        }
    }
}
