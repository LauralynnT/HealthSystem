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
        static int shield = 100;
        static Random rnd = new Random();
        static Random rhp = new Random();
        static ConsoleColor currentForeground = ConsoleColor.White;
        static void Main(string[] args)
        {
            currentForeground = ConsoleColor.White;
            Console.Write("Press Any Key To Start...\n");
            Console.ReadKey(true);
            while (lives!= 0)
            {
                HUD();
                Console.ReadKey(true);
                Heal();
                Console.ReadKey(true);
            }
            Console.WriteLine("\nOut of Lives");
            ColorString(0, "Game Over");
        }
        static void Damage()
        {
           int rDmg = rnd.Next(1, 100);
            Console.Write("\nPlayer takes ");
            ColorControl(1, rDmg);
            Console.Write(" damage\n");
            if (shield <= 0)
            {
                health -= rDmg;
            }
            
            else
            {
                shield -= rDmg;
            }
        }
        static void HUD()
        {
            ShieldStatus();
            HealthBar();
            Console.Write("\nLives: ");
            ColorControl(2, lives);
            Console.Write("\n");
        }
        static void Heal()
        {
            int rDmg = rnd.Next(10, 75);
            int roll = rhp.Next(1, 5);
            if(roll == 4)
            {
                Console.Write("\nPlayer Heals ");
                ColorControl(1, rDmg);
                Console.Write(" HP\n");
                if (shield <= 0)
                {
                    health += rDmg;
                }
                else if (shield <= 0 && health >= 100)
                {
                    shield = 0;
                    shield += rDmg;
                }
                else
                {
                    shield += rDmg;
                }
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
        static void ColorControl(int color, int sColor)
        {
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(sColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(sColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 2)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write(sColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(sColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void ColorString(int color, string fColor)
        {
            if (color == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 7)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 8)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 9)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == 11)
            {
                Console.ForegroundColor= ConsoleColor.Gray;
                Console.Write(fColor);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void HealthBar()
        {
            if (health <= 0)
            {
                Console.Write("\nHealth: ");
                ColorControl(1, 0);
                Console.Write(" (");
                ColorControl(1, health);
                Console.Write(")\nStatus: ");
                ColorString(0, "Dead\n");
                health = 100;
                shield = 100;
                lives--;
                Console.Write("Press Any Key To Continue...\n");
                Console.ReadKey(true);
                if (lives != 0)
                {
                    Console.Write("Shield: ");
                    ColorControl(0, shield);
                    ColorString(6, "\nShield Full");
                    Console.Write("\nHealth: ");
                    ColorControl(1, health);
                    Console.Write("\nStatus: ");
                    ColorString(1, "Perfect Health");
                }
            }
            else if (health > 0 && health <= 10)
            {
                Console.Write("\nHealth: ");
                ColorControl(1, health);
                Console.Write("\nStatus: ");
                ColorString(5, "Imminent Danger");
            }
            else if (health > 10 && health <= 50)
            {
                Console.Write("\nHealth: ");
                ColorControl(1, health);
                Console.Write("\nStatus: ");
                ColorString(4, "Badly Hurt");
            }
            else if (health > 50 && health <= 75)
            {
                Console.Write("\nHealth: ");
                ColorControl(1, health);
                Console.Write("\nStatus: ");
                ColorString(3, "Hurt");
            }
            else if (health > 75 && health < 100)
            {
                Console.Write("\nHealth: ");
                ColorControl(1, health);
                Console.Write("\nStatus: ");
                ColorString(2, "Healthy");
            }
            else if (health == 100)
            {
                Console.Write("\nHealth: ");
                ColorControl(1, health);
                Console.Write("\nStatus: ");
                ColorString(1, "Perfect Health");
            }
        }
        static void ShieldStatus()
        {
            if (shield <= 0)
            {
                Console.Write("Shield: ");
                ColorControl(0, 0);
                Console.Write(" (");
                ColorControl(3, shield);
                Console.Write(")\n");
                ColorString(11, "Shield Broken");
            }
            else if (shield > 0 && shield <= 10)
            {
                Console.Write("Shield: ");
                ColorControl(0, shield);
                ColorString(10, "\nShield Breaking");
            }
            else if (shield > 10 && shield <= 50)
            {
                Console.Write("Shield: ");
                ColorControl(0, shield);
                ColorString(9, "\nShield Badly Damaged");
            }
            else if (shield > 50 && shield <= 75)
            {
                Console.Write("Shield: ");
                ColorControl(0, shield);
                ColorString(8, "\nShield Damaged");
            }
            else if (shield > 75 && shield < 100)
            {
                Console.Write("Shield: ");
                ColorControl(0, shield);
                ColorString(7, "\nShield Good");
            }
            else if (shield >= 100)
            {
                Console.Write("Shield: ");
                ColorControl(0, 100);
                Console.Write(" (");
                ColorControl(0, shield);
                Console.Write(")");
                ColorString(6, "\nShield Full");
                shield = 100;
            }
        }
    }
}
