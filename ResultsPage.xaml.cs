using RugbyPlayerQuiz.Models;

namespace RugbyPlayerQuiz;

public partial class ResultsPage : ContentPage
{
    private QuizResult _result;
    private const string TELEGRAM_CHANNEL_URL = "https://t.me/RugbyQuiz";
    public string ResultText { get; set; }
    public string ScoreText { get; set; }
    public string PlayerStatus { get; set; }

    public ResultsPage()
    {
        InitializeComponent();
        _result = App.LastQuizResult;
        LoadResults();
        BindingContext = this;

        // Простое сохранение
        if (_result != null)
        {
            Preferences.Set("last_status", _result.PlayerStatus);
            Preferences.Set("last_date", _result.Date.ToString("O"));
        }
    }

    private void LoadResults()
    {
        var percentage = (_result.Score * 100) / _result.TotalQuestions;

        ResultText = percentage switch
        {
            >= 90 => "Отличный результат! 🏆",
            >= 70 => "Хорошая игра! 👍",
            >= 50 => "Неплохо! 😊",
            _ => "Попробуйте еще раз! 💪"
        };

        ScoreText = $"{_result.Score} из {_result.TotalQuestions} правильных ответов";
        PlayerStatus = _result.PlayerStatus;
    }
    private async void OnTelegramChannelClicked(object sender, EventArgs e)
    {
        try
        {
            var uri = new Uri(TELEGRAM_CHANNEL_URL);
            await Launcher.Default.OpenAsync(uri);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ошибка", "Не удалось открыть Telegram. Убедитесь, что приложение установлено.", "OK");
        }
    }

    private async void OnPlayAgainClicked(object sender, EventArgs e)
    {
        // Отправляем сообщение о сбросе игры
        MessagingCenter.Send(this, "ResetGame");

        // Возвращаемся на главную страницу
        await Shell.Current.GoToAsync("..");
    }

    private async void OnMainMenuClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(MenuPage)}");
    }

}