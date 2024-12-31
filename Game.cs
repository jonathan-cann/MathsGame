namespace Classes
{
    public class Game
    {
        public string[] AdditionGame()
        {
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