using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supre_Heros
{
    class Super_Man : Human, IFly
    {
        public override string Name { get; set; }
        public int Web_Left { get; private set; }

        public Super_Man(string name, int age, int web_left) : base(name, age)
        {
            Name = name;
            if (web_left >= 0)
            {
                Web_Left = web_left;
            }
        }

        public void Fly()
        {
            Console.WriteLine("I don't need airplane");
        }

        public void Activate_Super_Powers()
        {
            Fly();
        }

        public override string ToString()
        {
            return base.ToString() + " Web Left: " + Web_Left;
        }
    }
}
