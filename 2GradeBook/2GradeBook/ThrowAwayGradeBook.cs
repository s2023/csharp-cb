using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.ConsoleApp
{
    internal class ThrowAwayGradeBook : GradeBookModel
    {
        public ThrowAwayGradeBook(string name)
            :base(name)
            //:this()
        {
            Console.WriteLine("throwaway ctor");
            //Name = name;
        }

        public override void DoSomething()
        {
        }

        public override GradeStatistics ComputeStatistics()
        //public GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("throwaway Compute");
            float lowest = float.MaxValue;
            foreach (float grade in _grades)
            {
                lowest = Math.Min(lowest, grade);
            }
            _grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
