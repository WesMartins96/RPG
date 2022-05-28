using System;
using RPG.src.Entities;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hero arus = new Hero("Arus", 16, "Knight");
            Console.WriteLine(arus);           
            Console.WriteLine(arus.Attack());

            Console.WriteLine();

            Hero jennica = new Hero("Jennica", 23, "Mage");
            Console.WriteLine(jennica);
            Console.WriteLine(jennica.MageAttack());

            Console.WriteLine();

            Hero jubei = new Hero("Jubei", 18, "Ninja");
            Console.WriteLine(jubei);
            Console.WriteLine(jubei.NinjaAttack());

            Console.WriteLine();

            Enemy skeleton = new Enemy("Lord Skeleton", 22, "Skeleton");
            Console.WriteLine(skeleton);


            

        }
    }
}
