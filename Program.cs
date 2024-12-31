/*
Requirements:

- A basic maths game containing the four operations.
- The division should result in integers only and dividents should be between 0 and 100.
- Users should be presented with a menu to choose an option.
- Previous games should be recorded ina  list and there should be an option in the menu to visualise the history of the game.
- The results are deleted once the game is closed.

*/

using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        string? menuOption;
        List<GameResult> gameResults = [];

        Console.Clear();
        Console.WriteLine("Hi! Welcome to Number Ninjas!");

        do
        {
            menuOption = selectMenuOption();
            executeOption(menuOption);
        } while (menuOption != "6");

        Console.WriteLine("\nThanks for playing!");


        // Functions
        string selectMenuOption()
        {
            string? readResult;

            Console.WriteLine("\nPlease select a number from the list below:");
            Console.WriteLine("1. Play addition game");
            Console.WriteLine("2. Play subtraction game");
            Console.WriteLine("3. Play multiplication game");
            Console.WriteLine("4. Play division game");
            Console.WriteLine("5. View game history");
            Console.WriteLine("6. Exit game\n");

            readResult = Console.ReadLine();

            if (readResult == "1" || readResult == "2" || readResult == "3" || readResult == "4" || readResult == "5" || readResult == "6")
            {
                return readResult;
            }
            else
            {
                readResult = "0";
                return readResult;
            }
        }

        void executeOption(string menuOption)
        {
            switch (menuOption)
            {
                case "0":
                    {
                        Console.WriteLine("\nYou didn't select a number.");
                        break;
                    }

                case "1":
                    {
                        Game newGame = new();
                        string[] gameResult = newGame.AdditionGame();
                        GameResult newGameResult = new GameResult(gameResults.Count + 1, gameResult[0], gameResult[1], gameResult[2]);
                        gameResults.Add(newGameResult);
                        break;
                    }

                case "2":
                    {
                        break;
                    }

                case "3":
                    {
                        break;
                    }

                case "4":
                    {
                        break;
                    }

                case "5":
                    {
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}