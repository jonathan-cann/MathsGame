namespace Classes
{   
    public class GameResult
    {
        public int QuestionNumber { get; set; }
        public string Question { get; set; }
        public string YourAnswer { get; set; }
        public string Evaluation { get; set; }

        public GameResult (int questionNumber, string question, string yourAnswer, string evaluation)
        {
            QuestionNumber = questionNumber;
            Question = question;
            YourAnswer = yourAnswer;
            Evaluation = evaluation;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{QuestionNumber}. Question: {Question}, Your Answer: {YourAnswer}, {Evaluation}");
        }
    }
}