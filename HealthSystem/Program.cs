using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem
{
    internal class Program
    {
        static int health = 100;
        static int lives = 3;
        static Random rnd = new Random();
        static Random rhp = new Random();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Press Any Key To Start...\n");
            Console.ReadKey(true);
            while (lives!= 0)
            {
                Heal();
                HUD();
                Console.ReadKey(true);
            }
            Console.WriteLine("\nOut of Lives \nGame Over");
        }
        static void Damage()
        {
           int rDmg = rnd.Next(1, 100);
            Console.WriteLine("\nPlayer takes " + rDmg + " damage\n");
            health -= rDmg;
        }
        static void HUD()
        {
            if (health <= 0)
            {
                Console.WriteLine("health: 0 (" + health + ")\nStatus: dead");
                health = 100;
                lives--;
                Console.WriteLine("Press Any Key To Continue...\n");
                Console.ReadKey(true);
                if (lives != 0)
                {
                    Console.WriteLine("health: " + health + "\nStatus: perfect health");
                }
            }
            else if (health > 0 && health <= 10)
            {
                Console.WriteLine("health: " + health + "\nStatus: imminent danger");
            }
            else if (health > 0 && health <= 50)
            {
                Console.WriteLine("health: " + health + "\nStatus: badly hurt");
            }
            else if (health > 50 && health <= 75)
            {
                Console.WriteLine("health: " + health + "\nStatus: hurt");
            }
            else if (health > 75 && health < 100)
            {
                Console.WriteLine("health: " + health + "\nStatus: healthy");
            }
            else if (health == 100)
            {
                Console.WriteLine("health: " + health + "\nStatus: perfect health");
            }
            Console.WriteLine("Lives: " + lives);
        }
        static void Heal()
        {
            int rDmg = rnd.Next(10, 75);
            int roll = rhp.Next(1, 5);
            if(roll == 4)
            {
                Console.Write("\nPlayer Heals " + rDmg + "hp\n");
                health += rDmg;
                if (health > 100)
                {
                    health = 100;
                }
                
            }
            else
            {
                Damage();
            }
        }
    }
}
