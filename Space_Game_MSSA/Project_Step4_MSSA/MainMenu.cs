using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    public class Planets
    {


        public string MainMenu()
        {
            Console.Write("Hello, Welcome to __insert__name__");
                Console.WriteLine("\n");
            Console.Write("In this game, you need to get to __Planet 5__. \n\n" +
                            "In order to do so, you need to sell wares so you can afford the jet fuel to reach __Planet 5__.\n" +
                            "BEWARE...You may find it not so easy to reach __Planet 5__!");
            Console.WriteLine("\n");
                Console.WriteLine("Are you ready?");
            Console.WriteLine("Type continue to play, \nquit to exit the application");
            string answer = Console.ReadLine();


            if (answer == "quit")
            {
                Environment.Exit(0);
            }
            else if (answer == "continue")
            {
                Console.WriteLine("Good Luck traveler...");
            }
            else
            {
                Console.WriteLine("Nope!");

                while (answer != "quit" || answer != "continue")
                {
                    Console.WriteLine("Try again Traveler, try not capitalizing your answers!");
                    answer = Console.ReadLine();
                    break;
                }
            }
            //while (answer != "quit" || answer != "continue")
            //{
            //    Console.WriteLine("Try again Traveler, try not capitalizing your answers!");
            //    answer = Console.ReadLine();
            //    break;
            //}


            return answer;

        }
    }
}
