using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Chain_of_responsibility
{
    internal class Test4 :GarageHandler
    {
        public override void TestsHandler(Car car)
        {
            int testNumber = new Random().Next(1, 11);
            if (testNumber >= 6)
            {
                Console.WriteLine("The car passed Diagnosis test (4)");
                IsPassedTest4 = true;
                Console.WriteLine("The car is out of the garage!");

            }
            else
            {
                Console.WriteLine("The car has failed the Diagnosis test (4)...");
            }




        }
    }
}
