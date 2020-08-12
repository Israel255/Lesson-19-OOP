using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supre_Heros
{
    class Program
    {
        static void Activate_Hero(ISuper_Hero super_Hero)
        {
            super_Hero.Activate_Super_Powers();
        }
        static void Identify_Hero(ISuper_Hero super_)
        {
            if (super_ is Super_Man)
            {
                Console.WriteLine("Super Man Detected");
            }
            else if (super_ is Spider_Man)
            {
                Console.WriteLine("Spider Man Detected");
            }
            else if (super_ is Flash)
            {
                Console.WriteLine("Flash Detected");
            }
        }
        static void Get_More_Hero_Data(ISuper_Hero hero)
        {
            if (hero is Flash)
            {
                Flash x = hero as Flash;
                Console.WriteLine(x.Voltage);
            }
            else if (hero is Super_Man)
            {
                Super_Man y = hero as Super_Man;
                Console.WriteLine(y.Web_Left);
            }
            else if (hero is Spider_Man)
            {
                Spider_Man z = hero as Spider_Man;
                Console.WriteLine(z.Speed);
            }
        }
        static ISuper_Hero Create_Hero (string super_hero)
        {
            if (super_hero.GetType().Name == "Flash")
            {
                Flash flash = new Flash("Flash", 40, 180);
                return flash;
            }
            else if (super_hero.GetType().Name == "Super Man")
            {
                Super_Man super_Man = new Super_Man("Super Man", 50, 100);
                return super_Man;
            }
            else if (super_hero.GetType().Name == "Spider Man")
            {
                Spider_Man spider_Man = new Spider_Man("Spider Man", 60, 20);
                return spider_Man;
            }
            else
            {
                return null;
            }
        }
        static void Main(string[] args)
        {
            Flash flash = new Flash("Flash", 25, 200);
            Console.WriteLine(flash);
            Spider_Man spider_Man = new Spider_Man("Spider Man", 30, 600);
            Console.WriteLine(spider_Man);
            Super_Man super_man = new Super_Man("Super Man", 35, 500);
            Console.WriteLine(super_man);
            Console.WriteLine();

            Activate_Hero(flash);
            Activate_Hero(spider_Man);
            Activate_Hero(super_man);
            Console.WriteLine();

            ISuper_Hero[] supers = { flash, spider_Man, super_man };
            foreach(ISuper_Hero hero in supers)
            {
                Activate_Hero(hero);
            }
            Console.WriteLine();
            Identify_Hero(flash);
            Identify_Hero(spider_Man);
            Identify_Hero(super_man);
            Console.WriteLine();

            Get_More_Hero_Data(flash);
            Get_More_Hero_Data(spider_Man);
            Get_More_Hero_Data(super_man);
            Console.WriteLine();

            Console.WriteLine(Create_Hero("Flash"));
            Console.WriteLine(Create_Hero("Super Man"));
            Console.WriteLine(Create_Hero("Spider Man"));
            Console.WriteLine(Create_Hero("Wonder Woman"));
        }
    }
}
