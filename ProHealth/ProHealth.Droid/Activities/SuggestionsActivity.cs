
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;

namespace ProHealth.Droid.Activities
{
    [Activity(Label = "SuggestionsActivity")]
    public class SuggestionsActivity : BaseActivity
    {
        protected override int ActivityLayoutId => Resource.Layout.SuggestionsView;
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