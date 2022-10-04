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

            // This little bit holds all the data used throughout the code, like the score and health and the points values.

            // < Interger storage >

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



            // - Simulated Gameplay - v

            ShowHUD();

            AddScore(enemy1Points, 1); // Enemy Killed
            ShowHUD();

            AddScore(enemy2Points, 1);
            AddScore(enemy1Points, doublekill); // 2 Enemies killed in a row in under a few seconds, so bonus points given.
            ShowHUD();

            DoubleKillNotif(); // Player is told they got a double kill.
            DamageSystem(1); // Player takes damage.
            ShowHUD();

            DamageNotif(); // Player is told they took damage.
            ShowHUD();

            AddScore(enemy1Points, 1);
            AddScore(enemy3Points, doublekill);
            AddScore(enemy1Points, triplekill); // 3 Enemies killed in a row in under a few seconds, so MORE bonus points given.
            ShowHUD();

            DoubleKillNotif();
            TripleKillNotif(); // Player is told they got a triple kill.
            ShowHUD();

            DamageSystem(-1); // Player regains health.
            ShowHUD();
            Console.ReadKey(true);

            // - Simulated Gameplay - ^

        }
        static void ShowHUD()
        {
            Console.WriteLine("[=- - - - - -=]");
            Console.WriteLine("Score: " + score);    // This is the HUD itself.
            Console.WriteLine("Lives: " + health);
            Console.WriteLine("[=- - - - - -=]");
            Console.WriteLine();

        }

        static void DamageSystem(int damage) // This is the method for when damage is take. This is also used to heal players if they regain health.
        {
            health = health - damage;
        }

        static void DamageNotif() // This pops up whenever you take damage.
        {
            Console.WriteLine("<!> Life Lost! Watch yourself! <!>");
            Console.WriteLine();
        }

        static void AddScore(int points, int multiplyer) // This calulates the points you get per kill + whenever you get double or triple kills on what points to add.
        {
            score = score + points;
            score = score * multiplyer;
        }

        static void DoubleKillNotif() // This tells you when you get a double kill. This appears just under the HUD and (in theory) would vanish after a second.
        {
            Console.WriteLine("< Double Kill! >");
            Console.WriteLine();
        }
        static void TripleKillNotif() // This tells you when you get a triple kill. This appears just under the HUD and (in theory) would vanish after a second.
        {
            Console.WriteLine("< Triple Kill! >");
            Console.WriteLine();
        }
    }
}
