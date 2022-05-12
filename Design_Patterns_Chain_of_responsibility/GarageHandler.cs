using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Chain_of_responsibility
{
    abstract class GarageHandler
    {
        public GarageHandler NextHandel;
        public GarageHandler PrevHandler;
        public bool IsPassedTest1 { get; set; }
        public bool IsPassedTest2 { get; set; }
        public bool IsPassedTest3 { get; set; }
        public bool IsPassedTest4 { get; set; }

        public void SetNext(GarageHandler garageHandler)
        {
            NextHandel = garageHandler;
        }

        public void SetPrv(GarageHandler garageHandler)
        {
            PrevHandler = garageHandler;
        }


        public abstract void TestsHandler(Car car);

    }
}
