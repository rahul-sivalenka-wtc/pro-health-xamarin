
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;

namespace ProHealth.Droid.Activities
{
    [Activity(Label = "NotificationsActivity")]
    public class NotificationsActivity : BaseActivity
    {
        protected override int ActivityLayoutId => Resource.Layout.NotificationsView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            InitToolBar();
        }
        private void InitToolBar()
        {
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayShowTitleEnabled(false);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
        }
    }
}