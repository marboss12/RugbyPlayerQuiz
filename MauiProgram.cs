using Microsoft.Extensions.Logging;
using RugbyPlayerQuiz.Services;

namespace RugbyPlayerQuiz;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Убираем проблемный код с AddDebug
        // Вместо этого используем простую конфигурацию

        builder.Services.AddSingleton<IPlayerService, PlayerService>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MenuPage>();
        builder.Services.AddTransient<ResultsPage>();

        return builder.Build();
    }
}