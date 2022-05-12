using System;

namespace Design_Patterns_Chain_of_responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            Test3 test3 = new Test3();
            Test4 test4 = new Test4();


            test1.SetNext(test2);
            test2.SetPrv(test1);
            test2.SetNext(test3);
            test3.SetPrv(test2);
            test3.SetNext(test4);
            test4.SetPrv(test3);
            test4.SetNext(null);

            Car c1 = new Car(4554365, CarType.Toyota);
            Car c2 = new Car(097768789, CarType.Renu);
            Car c3 = new Car(23256, CarType.Mitsubitshi);
            Car c4 = new Car(124097, CarType.Jaguar);

            test1.TestsHandler(c1);










        }
    }
}
