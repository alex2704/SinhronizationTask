using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IEmergencyService
    {
        string Name { get; set; }
        void Help(Pedestrian objectPedestrian, Car objectCar);
    }
}
