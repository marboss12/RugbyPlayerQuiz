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
            // �������� ��������
            await LoadingImage.RotateTo(360, 1500, Easing.CubicOut);
            LoadingImage.Rotation = 0;

            // ��������� ����������� ��������
            _ = InfiniteRotation();

            // �������� �������� (2 �������)
            await Task.Delay(2000);

            // ������� �� ������� ���� ����� AppShell
            Application.Current.MainPage = new AppShell();

            // ��������� �� MenuPage
            await Shell.Current.GoToAsync("//MenuPage");
        }
        catch (Exception ex)
        {
            // ���� ��������� ������, ��� ����� ��������� �� �������
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