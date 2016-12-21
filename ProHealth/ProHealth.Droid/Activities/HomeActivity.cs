using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Java.Lang;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Fragments.Profile;
using ProHealth.Droid.Fragments.Records;
using ProHealth.Droid.Fragments.Schedule;
using ProHealth.Droid.Fragments.SearchDoctor;
using Fragment = Android.Support.V4.App.Fragment;

namespace ProHealth.Droid.Activities
{
    [Activity(
        LaunchMode = LaunchMode.SingleTop,
        NoHistory = true
    )]
    public class HomeActivity : BaseActivity
    {
        protected override int ActivityLayoutId => Resource.Layout.HomeView;

        private TabLayout tabLayout;
        private ViewPager viewPager;

        Fragment[] fragments = new Fragment[]
        {
            new SearchDoctorContainerFragment(),
            new RecordsContainerFragment(),
            new ScheduleContainerFragment(),
            new ProfileContainerFragment()
        };

        ICharSequence[] titles = CharSequence.ArrayFromStringArray(new[] 
        {
            "Search doctor",
            "Records",
            "Schedule",
            "Profile"
        });

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            viewPager = FindViewById<ViewPager>(Resource.Id.ViewPager);
            viewPager.Adapter = new HomeViewPagerAdapter(SupportFragmentManager, fragments, titles);

            tabLayout = FindViewById<TabLayout>(Resource.Id.SlidingTabs);
            tabLayout.SetupWithViewPager(viewPager);

            SetTabIcons();
        }

        private void SetTabIcons()
        {
            tabLayout.GetTabAt(0).SetIcon(Resource.Drawable.PersonIcon);
            tabLayout.GetTabAt(1).SetIcon(Resource.Drawable.PersonIcon);
            tabLayout.GetTabAt(2).SetIcon(Resource.Drawable.PersonIcon);
            tabLayout.GetTabAt(3).SetIcon(Resource.Drawable.PersonIcon);
        }
    }
}