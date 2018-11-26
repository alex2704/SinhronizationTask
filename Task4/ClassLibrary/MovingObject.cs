using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MovingObject
    {
        protected delegate void MovingSubject();//делегат
        protected event MovingSubject Move;
        protected event MovingSubject BumpInto;
        public bool MoveStatus { get; set; } = true;
        public bool BumpStatus { get; set; } = false;
        public void MoveOnGreen()
        {
            Move = () => MoveStatus = true;
            if (Move != null)
                Move.Invoke();
        }
        public void StopOnRed()
        {
            Move = () => MoveStatus = false;
            if (Move != null)
                Move.Invoke();
        }
        protected void EmergencyCase()
        {
            BumpInto += () => BumpStatus = true;
            if (BumpInto != null)
                BumpInto.Invoke();
        }
    }
}
