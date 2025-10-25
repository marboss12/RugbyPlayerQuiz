using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace RugbyPlayerQuiz.Platforms.Android
{
    [Activity(Theme = "@style/Maui.MainTheme", MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation 
        | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            // Используем MainTheme вместо SplashTheme
            base.OnCreate(savedInstanceState);
            Window.SetFlags(WindowManagerFlags.LayoutNoLimits, WindowManagerFlags.LayoutNoLimits);
        }
    }
}