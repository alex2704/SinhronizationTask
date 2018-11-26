using ClassLibrary;
using DrawingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class ClassForMove
    {
        public Car Car;
        public Pedestrian Pedestrian;
        public PictureBox PictureBox;
        public TrafficLight TrafficLight;
        public PictureBox EmergencyCauseBox;
        public int Number;
        public int NearestNumber;
        public ClassForMove(Car car, PictureBox pictureBox, TrafficLight trafficLight, PictureBox emergency, Pedestrian pedestrian, int number, int nearestNumber
            )
        {
            Car = car;
            PictureBox = pictureBox;
            TrafficLight = trafficLight;
            EmergencyCauseBox = emergency;
            Pedestrian = pedestrian;
            Number = number;
            NearestNumber = nearestNumber;
        }
        public ClassForMove(Pedestrian pedestrian, PictureBox pictureBox, TrafficLight trafficLight, PictureBox emergency, Car car, int number, int nearestNumber)
        {
            Pedestrian = pedestrian;
            PictureBox = pictureBox;
            TrafficLight = trafficLight;
            EmergencyCauseBox = emergency;
            Car = car;
            Number = number;
            NearestNumber = nearestNumber;
        }
        public ClassForMove(PictureBox pictureBox, Pedestrian pedestrian, Car car, int number, int nearestNumber)
        {
            PictureBox = pictureBox;
            Pedestrian = pedestrian;
            Car = car;
            Number = number;
            NearestNumber = nearestNumber;
        }

    }
}
