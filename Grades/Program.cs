using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook grades = new GradeBook();
            grades.AddGrade(grade: 91F);
            grades.AddGrade(grade: 89.5F);

            Console.ReadLine();
        }
    }
}
