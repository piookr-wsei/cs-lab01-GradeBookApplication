using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        RankedGradeBook(string name, GradeBookType type) : base(name)
        {
            base.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count > 5)
            {
                throw new InvalidOperationException("Too few students in this group.");
            }

            return base.GetLetterGrade(averageGrade);
        }

        public double RankGrade()
        {
            double percentage = 100 / Students.Count;

            List<int> grades = new List<int>();

            /*
            foreach(Grades gradeList in Students) { 
            }
            */
            return 0.2;
        }
    }
}