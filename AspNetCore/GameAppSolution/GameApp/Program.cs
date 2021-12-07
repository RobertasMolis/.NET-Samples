using System;
using System.Collections.Generic;

namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Fly f = new Fly();
            Rat r = new Rat();
            Dragon d = new Dragon();

            List<NPC> enemies = new List<NPC>();
            enemies.Add(f);
            enemies.Add(r);
            enemies.Add(d);
            Random random = new Random();
            int index = random.Next(0, 2);
            var enemy = enemies[index];

            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Fighter do you want attack enemy 'Yes' or 'No'");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    enemy.Attack();
                }
                if (answer.ToLower() == "no")
                {
                    Console.WriteLine("You coward...");
                }

            }
        }
    }
}
