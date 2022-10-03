using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int score;
        static int health;

        static void Main(string[] args)
        {
            Console.WriteLine("Methods");
            Console.WriteLine();

            // - - - - - - - - - - - - - - - - - - - - >

            score = 0;
            health = 3;

            // < Enemy Point Values >

            int enemy1Points;
            enemy1Points = 10;

            int enemy2Points;
            enemy2Points = 20;

            int enemy3Points;
            enemy3Points = 30;


            // < Multipliers >

            int doublekill;
            doublekill = 2;

            int triplekill;
            triplekill = 3;


            // - - - - - - - - - - - - - - - - - - - - >

            // - Simulated Gameplay - >

            ShowHUD();

            AddScore(enemy1Points, 1);
            ShowHUD();

            AddScore(enemy1Points, 1);
            AddScore(enemy1Points, doublekill);
            ShowHUD();

            DamageSystem(1);
            ShowHUD();

            DamageNotif();
            ShowHUD();

            Console.ReadKey(true);

            // - Simulated Gameplay - >
        }
        static void ShowHUD() // can put stuff in here for declaration stuff and simplification
        {
            Console.WriteLine("[=- - - - - -=]");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + health);
            Console.WriteLine("[=- - - - - -=]");
            Console.WriteLine();

        }

        static void DamageSystem(int damage)
        {
            health = health - damage;
        }

        static void DamageNotif()
        {
            Console.WriteLine("<> Life Lost! Watch yourself! <>");
            Console.WriteLine();
        }

        static void AddScore(int points, int multiplyer)
        {
            score = score + points;
            score = score * multiplyer;
        }

    }
}
