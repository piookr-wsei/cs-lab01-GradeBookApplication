using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks.Interface
{
    public interface IGradeBook
    {
        public string Name { get; set; }
        public GradeBookType Type { get; set; }
        public List<Student> Students { get; set; }

        public void AddStudent(Student student)
        {
        }

        public void RemoveStudent(string name)
        {
        }

        public void AddGrade(string name, double score)
        {
        }

        public void RemoveGrade(string name, double score)
        {
        }

        public void ListStudents()
        {
        }

        public void Save()
        {
        }

        public virtual void CalculateStatistics()
        {
        }

        public virtual void CalculateStudentStatistics(string name)
        {

        }
    }
}
