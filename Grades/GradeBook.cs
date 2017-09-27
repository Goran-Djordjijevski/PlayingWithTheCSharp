﻿using System;
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
    }
}
