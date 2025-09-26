namespace RugbyPlayerQuiz.Models
{
    public class QuizResult
    {
        public int Score { get; set; } = 0;
        public int TotalQuestions { get; set; } = 0;
        public string PlayerStatus { get; set; } = "Новичок";
        public DateTime Date { get; set; } = DateTime.Now;
    }
}