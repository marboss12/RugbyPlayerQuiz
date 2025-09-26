using Microsoft.Maui.Controls.Compatibility;
using RugbyPlayerQuiz.Models;
using RugbyPlayerQuiz.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace RugbyPlayerQuiz;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private readonly IPlayerService _playerService;
    private Player _currentPlayer;
    private List<Player> _usedPlayers = new();
    private int _score = 0;
    private int _questionNumber = 1;
    private const int TotalQuestions = 10;
    private bool _buttonsEnabled = true;
    private Player _selectedPlayer;

    public string QuestionCounter => $"Вопрос {_questionNumber}/{TotalQuestions}";
    public string ScoreText => $"Счет: {_score}";

    public Player CurrentPlayer
    {
        get => _currentPlayer;
        set
        {
            _currentPlayer = value;
            OnPropertyChanged(nameof(CurrentPlayer));
        }
    }

    public ObservableCollection<Player> Options { get; private set; } = new();

    public bool ButtonsEnabled
    {
        get => _buttonsEnabled;
        set
        {
            _buttonsEnabled = value;
            OnPropertyChanged(nameof(ButtonsEnabled));
        }
    }

    public MainPage(IPlayerService playerService)
    {
        InitializeComponent();
        _playerService = playerService;
        BindingContext = this;

        // Подписываемся на сообщение о сбросе игры
        MessagingCenter.Subscribe<ResultsPage>(this, "ResetGame", (sender) =>
        {
            ResetGame();
        });

        LoadNewQuestion();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (_questionNumber == 1 && _score == 0)
        {
            LoadNewQuestion();
        }
    }

    private void LoadNewQuestion()
    {
        if (_questionNumber > TotalQuestions)
        {
            EndGame();
            return;
        }

        // Сбрасываем стили кнопок ПЕРЕД созданием новой коллекции
        ResetButtonStyles();

        CurrentPlayer = GetUniquePlayer();
        var options = _playerService.GetRandomOptions(CurrentPlayer, 4);

        Options = new ObservableCollection<Player>(options);
        ButtonsEnabled = true;
        _selectedPlayer = null;

        OnPropertyChanged(nameof(QuestionCounter));
        OnPropertyChanged(nameof(ScoreText));
        OnPropertyChanged(nameof(Options));
    }

    private void ResetButtonStyles()
    {
        Device.BeginInvokeOnMainThread(() =>
        {
            var buttons = FindButtons();
            foreach (var button in buttons)
            {
                button.Style = (Style)Resources["DefaultButtonStyle"];
            }
        });
    }

    private Player GetUniquePlayer()
    {
        var player = _playerService.GetRandomPlayer();

        if (_usedPlayers.Count >= _playerService.GetPlayers().Count)
        {
            _usedPlayers.Clear();
        }

        while (_usedPlayers.Contains(player))
        {
            player = _playerService.GetRandomPlayer();
        }

        _usedPlayers.Add(player);
        return player;
    }
    private async void OnAnswerSelected(object sender, EventArgs e)
    {
        if (!ButtonsEnabled) return;

        ButtonsEnabled = false;

        if (sender is Button button && button.BindingContext is Player selectedPlayer)
        {
            _selectedPlayer = selectedPlayer;
            var isCorrect = selectedPlayer.Name == CurrentPlayer.Name;

            // Подсвечиваем ответы
            HighlightAnswers(isCorrect);

            if (isCorrect)
            {
                _score++;
                OnPropertyChanged(nameof(ScoreText));
            }

            await Task.Delay(1100);

            _questionNumber++;
            if (_questionNumber <= TotalQuestions)
            {
                LoadNewQuestion();
            }
            else
            {
                EndGame();
            }
        }
    }

    private void HighlightAnswers(bool isCorrect)
    {
        Device.BeginInvokeOnMainThread(async () =>
        {
            await Task.Delay(100); 

            var buttons = FindButtons();

            foreach (var button in buttons)
            {
                if (button.BindingContext is Player player)
                {
                    if (player.Name == CurrentPlayer.Name)
                    {
                        // Правильный ответ - зеленый
                        button.Style = (Style)Resources["CorrectButtonStyle"];
                    }
                    else if (!isCorrect && player.Name == _selectedPlayer?.Name)
                    {
                        // Неправильный выбор - красный
                        button.Style = (Style)Resources["IncorrectButtonStyle"];
                    }
                    else
                    {
                        // Остальные кнопки - стандартный стиль
                        button.Style = (Style)Resources["DefaultButtonStyle"];
                    }
                }
            }
        });
    }



    private List<Button> FindButtons()
    {
        var buttons = new List<Button>();

        if (OptionsContainer.Children != null)
        {
            foreach (var child in OptionsContainer.Children)
            {
                if (child is Button button)
                {
                    buttons.Add(button);
                }
            }
        }

        return buttons;
    }
    private async void EndGame()
    {
        var result = new QuizResult
        {
            Score = _score,
            TotalQuestions = TotalQuestions,
            Date = DateTime.Now,
            PlayerStatus = _playerService.GetPlayerStatus(_score)
        };

        App.LastQuizResult = result;

        await Shell.Current.GoToAsync(nameof(ResultsPage));
    }

    public void ResetGame()
    {
        _score = 0;
        _questionNumber = 1;
        _usedPlayers.Clear();
        Options.Clear();
        _selectedPlayer = null;
        OnPropertyChanged(nameof(QuestionCounter));
        OnPropertyChanged(nameof(ScoreText));
        LoadNewQuestion();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}