using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingObjects
{
    public class TrafficLight
    {
        Graphics g;
        Bitmap bitmap;
        public TrafficLights Light { get; set; } = TrafficLights.Green;
        public void CheckTrafficLight(object pictureBox)//регулирование цветов
        {
            bitmap = new Bitmap(((PictureBox)pictureBox).Width, ((PictureBox)pictureBox).Height);
            g = Graphics.FromImage(bitmap);
            Light = TrafficLights.Green;
            if (Light == TrafficLights.Green)
            {
                g.FillRectangle(Brushes.Black, new Rectangle(0, 0, ((PictureBox)pictureBox).Width, ((PictureBox)pictureBox).Height));
                g.FillEllipse(Brushes.Black, new Rectangle((((PictureBox)pictureBox).Width / 6), 11, ((PictureBox)pictureBox).Width * 4 / 6, 20));
                g.FillEllipse(Brushes.Green, new Rectangle((((PictureBox)pictureBox).Width / 6), 25, ((PictureBox)pictureBox).Width * 4 / 6, 20));
                ((PictureBox)pictureBox).Image = bitmap;
                Thread.Sleep(7000);
            }
            Light = TrafficLights.Red;
            if (Light == TrafficLights.Red)
            {
                g.FillRectangle(Brushes.Black, new Rectangle(0, 0, ((PictureBox)pictureBox).Width, ((PictureBox)pictureBox).Height));
                g.FillEllipse(Brushes.Black, new Rectangle((((PictureBox)pictureBox).Width / 6), 25, ((PictureBox)pictureBox).Width * 4 / 6, 20));
                g.FillEllipse(Brushes.Red, new Rectangle((((PictureBox)pictureBox).Width / 6), 5, ((PictureBox)pictureBox).Width * 4 / 6, 20));
                ((PictureBox)pictureBox).Image = bitmap;
                Thread.Sleep(4000);
            }
            CheckTrafficLight(pictureBox);
        }
    }
    public enum TrafficLights
    {
        Red,
        Green
    }
}
