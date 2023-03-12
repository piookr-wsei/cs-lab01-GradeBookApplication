using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        RankedGradeBook(string name) : base(name)
        {
            base.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count > 5)
            {
                throw new InvalidOperationException("Too few students in this group.");
            }

            return RankGrade(averageGrade);
        }


        public char RankGrade(double averageGrade)
        {
            List<double> grades = new List<double>();
            
            foreach(Student student in Students) {
                grades.Add(student.AverageGrade);
            }
            
            grades.Add(averageGrade);
            grades.Sort();

            double percentage = 100 / Students.Count;

            double percentile = percentage * grades.IndexOf(averageGrade);

            if(percentile >= 0.8)
            {
                return 'A';
            }
            else if(percentile >= 0.6)
            {
                return 'B';
            }
            else if(percentile >= 0.4)
            {
                return 'C';
            }
            else if(percentile >= 0.2)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}