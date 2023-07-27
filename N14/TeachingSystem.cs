using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14
{
    internal class TeachingSystem
    {
        public void DisplayCourses()
        {
            Console.WriteLine("Courses list : .NET");
        }

        protected void PlanOtherCourses()
        {
            Console.WriteLine("Planning other courses");
        }

        private void DisplayBalance()
        {
            Console.WriteLine("$56789");
        }

        public void SendStatisticsToBoss(string password)
        {
            DisplayBalance();
        }
    }

    internal class OnlineTeachingSystem : TeachingSystem
    {
        public void DisplayPlans()
        {
            PlanOtherCourses();
        }
    }
}
