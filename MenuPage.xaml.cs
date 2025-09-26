using System.ComponentModel;
using System.Runtime.CompilerServices;

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