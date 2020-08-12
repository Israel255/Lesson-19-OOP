using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supre_Heros
{
    class Flash : Human, IFlash
    {
        public override string Name { get; set; }
        public int Voltage { get;private set; }

        public Flash(string name, int age, int volt) : base(name, age)
        {
            Name = name;
            if (volt >= 0)
            {
                Voltage = volt;
            }
        }

        public void Fire_Lightnings()
        {
            Console.WriteLine("I'm Running, bye!!");
        }

        public void Activate_Super_Powers()
        {
            Fire_Lightnings();
        }

        public override string ToString()
        {
            return base.ToString() + " Volt: " + Voltage;
        }
    }
}
