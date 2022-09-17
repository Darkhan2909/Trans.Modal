using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trans.Modal.Modals
{
    public class Car: Trans
    {
        public Car() {
        
        }
        public Car(int maxSpeed = 260, int minSpeed = 10, string brand = "KIA", int number = 9, int speed = 0)
        {
            MaxSpeed = maxSpeed;
            MinSpeed = minSpeed;
            Brand = brand;
            Number = number;
            Speed = speed;
        }
        public readonly int MaxSpeed;
        public readonly int MinSpeed;

        public string Brand { get; set; }
        public int Number { get; set; }
        public int Speed { get; set; }

        private int speed_;

        public int speed
        {
            get
            {
                return speed_;
            }

            set
            {
                if (value > MaxSpeed)
                {
                    throw new Exception("Max Speed");
                }
                else
                {
                    speed_ = value;
                }
            }
        }

        public override void TransInfo()
        {
            string str = string.Format("Type Of transports {0}", TransName);
            Console.WriteLine(str);
            base.WeigthInfo(MaxWeight,MinWeight);
        }

        public override double WeigthInfo()
        {
            //return base.WeigthInfo()/0.25;
            return MaxWeight / 0.5;
        }
    }
}
