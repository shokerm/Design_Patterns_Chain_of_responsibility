using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Chain_of_responsibility
{
    internal class Car
    {
        public long CarNumber { get; set; }
        public CarType CarType { get; set; }

        public bool IsCarRepaired { get; set; }

        public Car(long carNumber, CarType carType)
        {
            CarNumber = carNumber;
            CarType = carType;
        }
    }



    public enum CarType
    {
        Renu,
        Toyota,
        Mitsubitshi,
        Citroen,
        Jaguar,
        Merzedes

    }

    
}

