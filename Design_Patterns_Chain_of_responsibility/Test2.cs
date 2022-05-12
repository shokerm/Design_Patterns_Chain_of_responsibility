using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Chain_of_responsibility
{
    internal class Test2 : GarageHandler

    {


        public override void TestsHandler(Car car)
        {
            int testNumber = new Random().Next(1, 11);
            if (testNumber >= 6)
            {
                Console.WriteLine("The car passed General Test By Mechanic (2)");
                IsPassedTest2 = true;
                NextHandel.TestsHandler(car);

            }
            else
            {
                Console.WriteLine("The car has failed the General Test By Mechanic (2)...");
            }




        }

    }
}
