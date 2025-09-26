using Android.App;
using Android.Content.PM;
using Android.OS;

namespace RugbyPlayerQuiz.Platforms.Android
{
    [Activity(Theme = "@style/Maui.SplashTheme",
              MainLauncher = true,
              ConfigurationChanges = ConfigChanges.ScreenSize |
                                   ConfigChanges.Orientation |
                                   ConfigChanges.UiMode |
                                   ConfigChanges.ScreenLayout |
                                   ConfigChanges.SmallestScreenSize |
                                   ConfigChanges.Density,
              ScreenOrientation = ScreenOrientation.Portrait)] // ← Добавьте эту строку
    public class MainActivity : MauiAppCompatActivity
    {
    }
}