using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Ambulance : IEmergencyService
    {
        public string Name { get; set; } = "Ambulance";
        public void Help(Pedestrian objectPedestrian, Car objectCar)
        {
            objectPedestrian.LifeStatus = PedestrianStatus.healthy;
            objectCar.CrashStatus = CarStatus.OnTheRun;
        }
        public Ambulance()
        {
        }
    }
}
