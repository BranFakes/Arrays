using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ammo System");
            //WE WISH TO STORE THE AMMO OF ALL WEAPONS
            //pistol + 6/6
            //shotgun = 2/2


            int Weapon = 0; // 0 = PISTOL, 1 = SHOTGUN, ETC.

            Console.WriteLine("BEFORE Arrays");
            int pistolAmmo = 6; // declaration + initialization
            int shotGunAmmo = 2;
            int bfgAmmo = 20;

            // HOW DO WE SHOW THE AMMO OF THE CURRENT WEAPON?

            if (Weapon == 0)
            {
                 Console.WriteLine("Pistol Ammo: " + pistolAmmo);
            }

           else if (Weapon == 1)
            {
                Console.WriteLine("Shotgun Ammo: " + shotGunAmmo);
            }

           else if (Weapon == 2)
            {
                Console.WriteLine("bfg Ammo: " + bfgAmmo);
            }




            Console.WriteLine("Arrays:");




            Console.ReadKey(true);
        }
    }
}
