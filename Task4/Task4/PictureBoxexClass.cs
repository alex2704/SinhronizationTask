using ClassLibrary;
using DrawingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public class PictureBoxexClass
    {
        public PictureBox Car_pictureBox { get; set; }
        public PictureBox FrontPedestrian_pb { get; set; }
        public PictureBox TrafficLight_pb { get; set; }
        public PictureBox Ambulance_pb { get; set; }
        public Panel PanelNumber { get; set; }
        public PictureBoxexClass(PictureBox car_box, PictureBox pedestrian_box, PictureBox trafficlight_box, PictureBox ambulance_box, Panel panel)
        {
            Car_pictureBox = car_box;
            FrontPedestrian_pb = pedestrian_box;
            TrafficLight_pb = trafficlight_box;
            Ambulance_pb = ambulance_box;
            PanelNumber = panel;
        }
    }
}
