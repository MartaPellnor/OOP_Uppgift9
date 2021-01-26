using System;

namespace OOP_Uppgift9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors game!");
            
            Console.WriteLine("ROUND 1");
            string playerInput = PlayerTurn();
            string computerInput = ComputerTurn();



            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static string PlayerTurn()
        {
            string playerInput;

            do {
                Console.WriteLine("Will you choose Rock (r), Paper (p) or Scissors (s)?");
                playerInput = Console.ReadLine();

                if(playerInput == "r" || playerInput == "p" || playerInput == "s") {

                }
                else {
                    Console.WriteLine("Please write one of the letters 'r', 'p' or 's' in lower case.");
                }
            }while(playerInput != "r" || playerInput != "p" || playerInput != "s");

            return playerInput;
        }

        static string ComputerTurn()
        {
            return;
        }

        static int Score()
        {

            return;
        }
    }
}
