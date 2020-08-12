using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supre_Heros
{
    abstract class Human
    {
        public abstract string Name { get; set; }
        private int _age;

        public Human(string name, int age)
        {
            Name = name;
            _age = age;
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public override string ToString()
        {
            return "Super Hero Name: " + Name + " Age: " + Age;
        }
    }
}
