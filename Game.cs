using System;

namespace Classes
{
    public class Game
    {
        public string[] AdditionGame()
        {
            string newGame = "yes";
            Random random = new Random();

            Console.Clear();
            Console.WriteLine("Welcome to the addition game! Let's see what you're made of!");
            do
            {
                int randOne = random.Next(0, 100), randTwo = random.Next(0, 100);
                int answer = randOne + randTwo;

                Console.WriteLine($"{randOne} + {randTwo} =");
                string? userAnswer = Console.ReadLine();

                
            } while (newGame != "no");
            // while loop
            // generate two random numbers between 0 and 100
            // get the answer when they're added
            // ask the question and accept the answer
            // either correct or incorrect
            // add the result to the gameresult array
            // ask if they want another question


            return ["1 + 1 = 2", "3", "Incorrect"];
        }

        public string[] SubtractionGame()
        {
            return ["3 - 2 = 1", "1", "Correct"];
        }

        public string[] MultiplicationGame()
        {
            return ["2 * 3 = 6", "6", "Correct"];
        }

        public string[] DivisionGame()
        {
            return ["10 / 2 = 5", "2", "Incorrect"];
        }
    }
}