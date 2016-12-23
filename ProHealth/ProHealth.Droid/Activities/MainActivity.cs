using Android.App;
using Android.Content.PM;
using Android.OS;
using ProHealth.Droid.Activities;
using ProHealth.Droid.Fragments;

namespace ProHealth.Droid
{
    [Activity(
        LaunchMode = LaunchMode.SingleTop,
        NoHistory = true
    )]
    public class MainActivity : BaseActivity
    {
        protected override int ActivityLayoutId => Resource.Layout.MainView;

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            ShowLogin();
        }

        private void ShowLogin()
        {
            GotoNextFragment<LoginFragment>(Resource.Id.Root, false);
        }
    }
}

