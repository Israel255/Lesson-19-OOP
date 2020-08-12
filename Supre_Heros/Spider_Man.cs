using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supre_Heros
{
    class Spider_Man : Human, IClimb
    {
        public override string Name { get; set; }
        public int Speed { get;private set; }

        public Spider_Man(string name, int age, int speed) : base(name, age)
        {
            Name = name;
            if (speed >= 0)
            {
                Speed = speed;
            }
        }

        public void Climb()
        {
            Console.WriteLine("See you in 16 floor");
        }

        public void Activate_Super_Powers()
        {
            Climb();
        }

        public override string ToString()
        {
            return base.ToString() + " Speed: " + Speed;
        }
    }
}
