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


       




            Console.WriteLine();
            

            int lives = 3; //example of int

            Console.WriteLine("Arrays:");

            int[] ammo; // declaration (telling the compiler what "ammo" is)
            //"int[]" means "array of integers'
            // so, "ammo" is an "array of integers"

            ammo = new int[3]; //initialization (telling the compiler the size)
            ammo[0] = 6; //pistol
            ammo[1] = 2; //shotgun
            ammo[2] = 20; //bfg

            string[] weaponName = new string[3]; // declaration + init. combined
            weaponName[0] = "pistol";
            weaponName[1] = "shotgun";
            weaponName[2] = "bfg";


            Console.WriteLine("ammo: " + ammo[Weapon]);
            // HOW DO WE SHOW THE AMMO OF THE CURRENT WEAPON?

            Console.WriteLine("pistol Ammo: " + ammo[0]);
            Console.WriteLine("shotgun Ammo: " + ammo[1]);
            Console.WriteLine("bfg Ammo: " + ammo[2]);



            Console.ReadKey(true);
        }
    }
}
