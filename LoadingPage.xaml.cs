namespace RugbyPlayerQuiz;

public partial class LoadingPage : ContentPage
{
    public LoadingPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await StartLoadingAnimation();
    }

    private async Task StartLoadingAnimation()
    {
        try
        {
            // Анимация вращения
            await LoadingImage.RotateTo(360, 1500, Easing.CubicOut);
            LoadingImage.Rotation = 0;

            // Запускаем бесконечное вращение
            _ = InfiniteRotation();

            // Имитация загрузки (2 секунды)
            await Task.Delay(2000);

            // Переход на главное меню через AppShell
            Application.Current.MainPage = new AppShell();

            // Навигация на MenuPage
            await Shell.Current.GoToAsync("//MenuPage");
        }
        catch (Exception ex)
        {
            // Если произошла ошибка, все равно переходим на главную
            Application.Current.MainPage = new AppShell();
        }
    }

    private async Task InfiniteRotation()
    {
        while (true)
        {
            await LoadingImage.RotateTo(360, 3000, Easing.Linear);
            LoadingImage.Rotation = 0;
            await Task.Delay(100);
        }
    }
}