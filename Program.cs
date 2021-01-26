using System;

namespace OOP_Uppgift9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors game!");
            
            int numberOfRounds = 1;
            int playerScore = 0;
            int computerScore = 0;
            string winner;

            do {
                Console.WriteLine("ROUND {0}", numberOfRounds);
                winner = Round();
                if (winner == "player"){
                    playerScore++;
                }
                else if (winner == "computer"){
                    computerScore++;
                }
                else if (winner == "tie"){

                }

            }while(playerScore < 3 || computerScore < 3);

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static string Round() {
            string playerInput = PlayerTurn();
            string computerInput = ComputerTurn();
            string winner = WhoWon(playerInput, computerInput);

            return winner;
        }

        static string PlayerTurn()
        {
            string playerInput;

            do {
                Console.WriteLine("Will you choose Rock (r), Paper (p) or Scissors (s)?");
                playerInput = Console.ReadLine();

                if(playerInput == "r" || playerInput == "p" || playerInput == "s") {
                    if(playerInput == "r"){
                        Console.WriteLine("You chose Rock!");
                    }
                    else if(playerInput == "p"){
                        Console.WriteLine("You chose Paper!");
                    }
                    else if(playerInput == "s"){
                        Console.WriteLine("You chose Scissors!");
                    }
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
                Console.WriteLine("The computer chose Rock!");
            }
            else if (computerInput == 1){
                computerInputLetter = "p";
                Console.WriteLine("The computer chose Paper!");
            }
            else if (computerInput == 2){
                computerInputLetter = "s";
                Console.WriteLine("The computer chose Scissors!");
            }

            return computerInputLetter;
        }

        static string WhoWon(string playerinput, string computerInput) {

            string winner = "null";

            if (playerinput == "r" && computerInput == "r") {
                winner = "tie";
            }
            else if (playerinput == "r" && computerInput == "p") {
                winner = "computer";
            }
            else if (playerinput == "r" && computerInput == "s") {
                winner = "player";
            }
            else if (playerinput == "p" && computerInput == "r") {
                winner = "player";
            }
            else if (playerinput == "p" && computerInput == "p") {
                winner = "tie";
            }
            else if (playerinput == "p" && computerInput == "s") {
                winner = "computer";
            }
            else if (playerinput == "s" && computerInput == "r") {
                winner = "computer";
            }
            else if (playerinput == "s" && computerInput == "p") {
                winner = "player";
            }
            else if (playerinput == "s" && computerInput == "s") {
                winner = "tie";
            }

            return winner;
        }

    }
}
