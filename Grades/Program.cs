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
            GradeBook book = new GradeBook();
            book.AddGrade(grade: 91F);
            book.AddGrade(grade: 89.5F);

            GradeBook book2 = book;
            book2.AddGrade(grade: 75);

            Console.ReadLine();
        }
    }
}
