using System;
using System.Collections;
using System.Collections.Generic;


namespace GradeBook.ConsoleApp
{
    public class GradeBookModel : GradeTracker
    {
        public GradeBookModel(string name = "There is no name")
        {
            Console.WriteLine("gradebookm ctor");
            Name = name;
            _grades = new List<float>();
        }

        public override IEnumerator GetEnumerator()
        {
            return _grades.GetEnumerator();
        }

        public override void DoSomething()
        {

        }

        public override void AddGrade(float grade)
        //v1 public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }

        //public bool ThrowAwayLowest { get; set; } v1

        public override GradeStatistics ComputeStatistics()
        //v1 public virtual GradeStatistics ComputeStatistics()
        //public GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradebookCompSts Compute");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;
            foreach (float grade in _grades) 
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            //if (ThrowAwayLowest); v1
            stats.AverageGrade = sum / _grades.Count;
            return stats;
        }

        public override void WriteGrades(TextWriter textWriter)
        //v1 public void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades:");
            int i = 0;
            do
            {
                textWriter.WriteLine(_grades[i]);
                i++;
            } while (i < _grades.Count);
            //while (true)
            ////while (i < _grades.Count)
            //{
            //    textWriter.WriteLine(_grades[i]);
            //    i++;
            //}
            //for (int i = _grades.Count - 1; i >= 0; i++)
            ////for (int i = 0; i < _grades.Count; i++)
            //{
            //    textWriter.WriteLine(_grades[i]);
            //}
            //foreach (float grade in _grades)
            //{
            //    textWriter.WriteLine(grade);
            //}
            textWriter.WriteLine("***************");
        }

        // v1 lo que se corta a GradeTracker

        protected List<float> _grades;

    }
}
