using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pedestrian : MovingObject
    {
        public PedestrianStatus LifeStatus { get; set; } = PedestrianStatus.healthy;
        public Pedestrian()
        {

        }
        public void PedestrianEmergencyCase()
        {
            Random rnd = new Random();
            BumpInto+=()=>LifeStatus = (PedestrianStatus)rnd.Next(0, 2);
            EmergencyCase();
        }
    }
}
