using System.ComponentModel;
using System.Runtime.CompilerServices;
using RugbyPlayerQuiz.Services;
namespace RugbyPlayerQuiz;

public partial class MenuPage : ContentPage, INotifyPropertyChanged
{
    private string _currentStatus;
    private string _lastGameDate;

    public string CurrentStatus
    {
        get => _currentStatus;
        set
        {
            _currentStatus = value;
            OnPropertyChanged();
        }
    }

    public string LastGameDate
    {
        get => _lastGameDate;
        set
        {
            _lastGameDate = value;
            OnPropertyChanged();
        }
    }

    public MenuPage()
    {
        InitializeComponent();
        BindingContext = this;
        Title = "Главное меню";
    }
    private async void OnRussianChampionshipClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }

    private async void OnMixedLeagueClicked(object sender, EventArgs e)
    {
        try
        {
            System.Diagnostics.Debug.WriteLine("🎯 Кнопка MixedLeague нажата");

            // Проверяем DI контейнер
            var services = App.Current?.Handler?.MauiContext?.Services;
            if (services == null)
            {
                System.Diagnostics.Debug.WriteLine("❌ MauiContext.Services is NULL");
                await DisplayAlert("Ошибка", "MauiContext не доступен", "OK");
                return;
            }

            // Пробуем получить сервис
            var mixedService = services.GetService<MixedLeaguePlayerService>();
            System.Diagnostics.Debug.WriteLine($"🔧 MixedLeaguePlayerService: {mixedService != null}");

            if (mixedService == null)
            {
                // Пробуем создать вручную
                System.Diagnostics.Debug.WriteLine("🛠️ Создаем сервис вручную...");
                var playerService = services.GetService<IPlayerService>();
                System.Diagnostics.Debug.WriteLine($"🔧 IPlayerService: {playerService != null}");

                if (playerService != null)
                {
                    mixedService = new MixedLeaguePlayerService(playerService);
                    System.Diagnostics.Debug.WriteLine($"🛠️ Ручной сервис создан: {mixedService != null}");
                }
            }

            if (mixedService != null)
            {
                var players = mixedService.GetPlayers();
                System.Diagnostics.Debug.WriteLine($"👥 Игроков в сервисе: {players?.Count ?? 0}");

                if (players != null && players.Any())
                {
                    System.Diagnostics.Debug.WriteLine("✅ Все проверки пройдены, переходим...");
                    await Shell.Current.GoToAsync("///MixedLeaguePage");
                    return;
                }
            }

            await DisplayAlert("Ошибка", "Не удалось инициализировать игру", "OK");
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"💥 КРИТИЧЕСКАЯ ОШИБКА: {ex}");
            await DisplayAlert("Критическая ошибка", ex.Message, "OK");
        }
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadLastResult();
    }

    private void LoadLastResult()
    {
        // Простая проверка: есть ли сохраненные данные
        if (Preferences.ContainsKey("last_status"))
        {
            CurrentStatus = Preferences.Get("last_status", "Новичок");
            var lastDate = Preferences.Get("last_date", DateTime.Now.ToString());
            LastGameDate = $"Последняя игра: {DateTime.Parse(lastDate):dd.MM.yyyy HH:mm}";
        }
        else if (App.LastQuizResult != null && App.LastQuizResult.TotalQuestions > 0)
        {
            CurrentStatus = App.LastQuizResult.PlayerStatus;
            LastGameDate = $"Последняя игра: {App.LastQuizResult.Date:dd.MM.yyyy HH:mm}";
        }
        else
        {
            CurrentStatus = "Новичок";
            LastGameDate = "Играйте впервые!";
        }

        OnPropertyChanged(nameof(CurrentStatus));
        OnPropertyChanged(nameof(LastGameDate));
    }

    private async void OnStartGameClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }

    private void OnExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}