using ClassLibrary;
using DrawingObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //crosswalk_pictureBox.Controls.Add(ambulance_pb);
            //crosswalk_pictureBox.Controls.Add(car_pictureBox);
            //crosswalk_pictureBox.Controls.Add(frontPedestrian_pb);
            ambulance_pb.Visible = false;
            trafficLight_pb.Visible = false;
            ambulance3_pb.Visible = false;
            trafficLight3_pb.Visible = false;
            ambulance2_pb.Visible = false;
            trafficLight2_pb.Visible = false;
            ambulance4_pb.Visible = false;
            trafficLight4_pb.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }
        static int count = 1;
        static int NearestCount1 = 0;
        static int NearestCount2 = 0;
        private static void StartCrossWalkForThread(object boxClass)
        {
            StartCrossWalk(((PictureBoxexClass)boxClass).Car_pictureBox, ((PictureBoxexClass)boxClass).FrontPedestrian_pb, ((PictureBoxexClass)boxClass).TrafficLight_pb, ((PictureBoxexClass)boxClass).Ambulance_pb, ((PictureBoxexClass)boxClass).PanelNumber);
        }
        private static void StartCrossWalk(PictureBox car_pictureBox, PictureBox frontPedestrian_pb, PictureBox trafficLight_pb, PictureBox ambulance_pb, Panel panel)
        {
            panel.Invoke(new MethodInvoker(() =>
                    panel.Visible = true));
            //panel.Visible = true;
            TrafficLight trafficLight = new TrafficLight();
            Pedestrian pedestrian = new Pedestrian();
            Car car = new Car();
            //переключение светофора
            Thread SwitchTrafficThread = new Thread(new ParameterizedThreadStart(trafficLight.CheckTrafficLight));
            trafficLight_pb.Invoke(new MethodInvoker(() =>
                    trafficLight_pb.Visible = true));
            //trafficLight_pb.Visible = true;
            SwitchTrafficThread.Start(trafficLight_pb);
            ////движение машины
            Thread moveCarThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectCar));
            ClassForMove myObject1Car = new ClassForMove(car, car_pictureBox, trafficLight, frontPedestrian_pb, pedestrian, NearestCount1, NearestCount2);
            moveCarThread.Start(myObject1Car);
            ////движение пешехода переднего
            Thread frontPedestrianThread = new Thread(new ParameterizedThreadStart(Utils.MoveObjectFrontPedestrian));
            ClassForMove myObject2Pedestrian = new ClassForMove(pedestrian, frontPedestrian_pb, trafficLight, car_pictureBox, car, NearestCount1, NearestCount2);
            frontPedestrianThread.Start(myObject2Pedestrian);
            //аварийный случай
            Thread ambulanceThread = new Thread(new ParameterizedThreadStart(Utils.CheckEmergencyCase));
            ClassForMove myObject3Ambulance = new ClassForMove(ambulance_pb, pedestrian, car, NearestCount1, NearestCount2);
            ambulanceThread.Start(myObject3Ambulance);
        }
        private void StartFilm_btn_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    NearestCount2 = 2;
                    NearestCount1 = 1;
                    PictureBoxexClass pictureBoxexClass1 = new PictureBoxexClass(car_pictureBox, frontPedestrian_pb, trafficLight_pb, ambulance_pb, panel1);
                    Thread StartCrossWalkThread1 = new Thread(new ParameterizedThreadStart(StartCrossWalkForThread));
                    StartCrossWalkThread1.Start((pictureBoxexClass1));
                    count++;
                    break;
                case 2:
                    NearestCount2 = 1;
                    NearestCount1 = 2;
                    PictureBoxexClass pictureBoxexClass2 = new PictureBoxexClass(car2_pictureBox, frontPedestrian2_pb, trafficLight2_pb, ambulance2_pb, panel3);
                    Thread StartCrossWalkThread2 = new Thread(new ParameterizedThreadStart(StartCrossWalkForThread));
                    StartCrossWalkThread2.Start((pictureBoxexClass2));
                    count++;
                    break;
                case 3:
                    NearestCount2 = 4;
                    NearestCount1 = 3;
                    PictureBoxexClass pictureBoxexClass3 = new PictureBoxexClass(car3_pictureBox, frontPedestrian3_pb, trafficLight3_pb, ambulance3_pb, panel2);
                    Thread StartCrossWalkThread3 = new Thread(new ParameterizedThreadStart(StartCrossWalkForThread));
                    StartCrossWalkForThread((pictureBoxexClass3));
                    count++;
                    break;
                case 4:
                    NearestCount2 = 4;
                    NearestCount1 = 3;
                    PictureBoxexClass pictureBoxexClass4 = new PictureBoxexClass(car4_pictureBox, frontPedestrian4_pb, trafficLight4_pb, ambulance4_pb, panel4);
                    Thread StartCrossWalkThread4 = new Thread(new ParameterizedThreadStart(StartCrossWalkForThread));
                    StartCrossWalkForThread((pictureBoxexClass4));
                    count++;
                    break;
                case 5:
                    MessageBox.Show("К сожалению больше нет места");
                    break;
            }
        }
    }
}
