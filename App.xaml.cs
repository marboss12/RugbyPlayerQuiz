using RugbyPlayerQuiz.Models;

namespace RugbyPlayerQuiz;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }

    public static QuizResult LastQuizResult { get; set; } = new QuizResult
    {
        PlayerStatus = "ДЮСШ Южное Тушино",
        Date = DateTime.Now,
        Score = 0,
        TotalQuestions = 10
    };

}