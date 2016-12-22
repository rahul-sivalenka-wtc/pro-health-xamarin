using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using System.Threading.Tasks;

namespace ProHealth.Droid
{
    [Activity(
        Label = "@string/ApplicationName",
        Theme = "@style/AppTheme.Splash",
        MainLauncher = true,
        NoHistory = true
    )]
    public class SplashScreen : AppCompatActivity
    {
        private int splashTimeout = 3000;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //this.SupportActionBar.Hide();
        }

        protected async override void OnResume()
        {
            base.OnResume();

            await Task.Delay(splashTimeout);

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}