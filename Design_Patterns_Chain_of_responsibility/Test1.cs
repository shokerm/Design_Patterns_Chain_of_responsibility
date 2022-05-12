using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Chain_of_responsibility
{
    internal class Test1 : GarageHandler
    {
        

        public override void TestsHandler(Car car)
        {
            int testNumber = new Random().Next(1, 11);
            if (testNumber >= 6)
            {
                Console.WriteLine("The car passed Initial test(1)");
                IsPassedTest1 = true;
                NextHandel.TestsHandler(car);

            }
            else
            {
                Console.WriteLine("The car has failed Initial test(1)...");
            }
              
          


        }
    }
}
