using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car:MovingObject
    {
        public CarStatus CrashStatus { get; set; } = CarStatus.OnTheRun;
        public Car()
        {

        }
        public void CarEmergencyCase()
        {
            Random rnd = new Random();
            BumpInto += () => CrashStatus = (CarStatus)rnd.Next(0, 2);
            EmergencyCase();
        }
    }

}
