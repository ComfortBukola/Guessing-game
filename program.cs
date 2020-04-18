using System;

namespace Loops {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Please select a level, easy,medium,hard:");
            string input = "";
            input = Console.ReadLine ();
            if (input == "easy") {
                int? guess = 0;
                Console.Write ("Choose a number between 1-10:");
                guess = Convert.ToInt32 (Console.ReadLine ());
                int numberOfGuessesLeft = 5;
                int i = 0;
                while (guess != 3) {
                    Console.Write ("That was wrong, you have" + numberOfGuessesLeft + "number of guesses left. make another guess:");
                    i++;
                    numberOfGuessesLeft--;
                    guess = Convert.ToInt32 (Console.ReadLine ());
                    if (guess == 3) {
                        break;
                    } else if (i == 5) {
                        Console.Write ("You have 0 number of guesses left.Gameover!");
                        return;
                    }
                }
                Console.WriteLine ("You got it right!");
            }
            if (input == "medium") {
                int? guess = 0;
                Console.Write ("Choose a number between 1-20:");
                guess = Convert.ToInt32 (Console.ReadLine ());
                int numberOfGuessesLeft = 3;
                int i = 0;
                while (guess != 4) {
                    Console.Write ("That was wrong, you have" + numberOfGuessesLeft + "number of guesses left. make another guess:");
                    i++;
                    numberOfGuessesLeft--;
                    guess = Convert.ToInt32 (Console.ReadLine ());
                    if (guess == 4) {
                        break;
                    } else if (i == 3) {
                        Console.Write ("You have 0 number of guesses left.Gameover!");
                        return;
                    }
                }
                Console.WriteLine ("You got it right!");
            }
            if (input == "hard") {
                int? guess = 0;
                Console.Write ("Choose a number between 1-50:");
                guess = Convert.ToInt32 (Console.ReadLine ());
                int numberOfGuessesLeft = 2;
                int i = 0;
                while (guess != 5) {
                    Console.Write ("That was wrong, you have" + numberOfGuessesLeft + "number of guesses left. make another guess:");
                    i++;
                    numberOfGuessesLeft--;
                    guess = Convert.ToInt32 (Console.ReadLine ());
                    if (guess == 5) {
                        break;
                    } else if (i == 2) {
                        Console.Write ("You have 0 number of guesses left.Gameover!");
                        return;
                    }
                }
                Console.WriteLine ("You got it right!");
            }
        }
    }
}
