using System;
using System.Collections.Generic;
using LeagueManager.Common;

namespace LeagueManager
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("Welcome to League Manager!");

            while (running)
            {
                showMenu();
                string test = Console.ReadLine();

                if(test.Equals("1"))
                {
                    //Player test = new Player()
                }

            }
        }
        static void showMenu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Menu selection:");
            Console.WriteLine("1. Create a new Player.");
            Console.WriteLine("2. TBDs");
        }
    }
}
