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
            WhoWon(playerInput, computerInput);


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
            Random numberGenerator = new Random();

            int computerInput = numberGenerator.Next(0,3);
            string computerInputLetter = "null";

            if (computerInput == 0) {
                computerInputLetter = "r";
            }
            else if (computerInput == 1){
                computerInputLetter = "p";
            }
            else if (computerInput == 2){
                computerInputLetter = "s";
            }

            return computerInputLetter;
        }

        static void WhoWon(string playerinput, string computerInput) {

        }

        static int Score()
        {

            return;
        }
    }
}
