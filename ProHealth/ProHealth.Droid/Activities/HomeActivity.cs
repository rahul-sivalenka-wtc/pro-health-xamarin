using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using Java.Lang;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Fragments.Profile;
using ProHealth.Droid.Fragments.Records;
using ProHealth.Droid.Fragments.Schedule;
using ProHealth.Droid.Fragments.SearchDoctor;
using Fragment = Android.Support.V4.App.Fragment;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.Widget;

namespace ProHealth.Droid.Activities
{
    [Activity(
        LaunchMode = LaunchMode.SingleTop,
        NoHistory = true,
        MainLauncher = true, Theme = "@style/AppTheme.Base"
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

        Fragment[] weeksFragments = new Fragment[] {
                new MondayFragment(),
                new TuesdayFragment(),
                new WednesdayFragment(),
                new ThursdayFragment(),
                new FridayFragment(),
                new SaturdayFragment()
             };

        ICharSequence[] weeksTitles = CharSequence.ArrayFromStringArray(new[] {
                    "M","T","W","T","F","S"
                });
        private BottomSheetBehavior mBottomSheetBehavior;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            InitToolBar();

            viewPager = FindViewById<ViewPager>(Resource.Id.ViewPager);
            viewPager.Adapter = new HomeViewPagerAdapter(SupportFragmentManager, fragments, titles);

            tabLayout = FindViewById<TabLayout>(Resource.Id.SlidingTabs);
            tabLayout.SetupWithViewPager(viewPager);

            OncreteTabLayout();
            WireEvents();
        }

        private void InitToolBar()
        {
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayShowTitleEnabled(false);
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }

        private void WireEvents()
        {
            SupportFragmentManager.BackStackChanged += SupportFragmentManager_BackStackChanged;
        }

        private void SupportFragmentManager_BackStackChanged(object sender, EventArgs e)
        {
            var backStackEntryCount = SupportFragmentManager.BackStackEntryCount;
            if (backStackEntryCount == 1)
                SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            else
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
        }

        private void OncreteTabLayout()
        {
            View bottomSheet = FindViewById(Resource.Id.weeksLayouts);
            bottomSheet.BringToFront();
            mBottomSheetBehavior = BottomSheetBehavior.From(bottomSheet);
            viewPager = FindViewById<ViewPager>(Resource.Id.DoctorInfoViewPager);
            viewPager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, weeksFragments, weeksTitles);
            var doctorInfoTabLayout = FindViewById<TabLayout>(Resource.Id.DoctorInfoSlidingTabs);
            doctorInfoTabLayout.SetupWithViewPager(viewPager);
            SetTabIcons();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.action_menu, menu);
            if (menu != null)
            {
                menu.FindItem(Resource.Id.search_bar).SetVisible(true);
                menu.FindItem(Resource.Id.notifications).SetVisible(true);
            }
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    SupportFragmentManager.PopBackStackImmediate();
                    return true;
                case Resource.Id.search_bar:
                    GotoNextActivity<SuggestionsActivity>();
                    break;
                case Resource.Id.notifications:
                    GotoNextActivity<NotificationsActivity>();
                    break;
                default:
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        public void ShowBottomSheet()
        {
            mBottomSheetBehavior.State = BottomSheetBehavior.StateExpanded;
        }

        private void SetTabIcons()
        {
            tabLayout.GetTabAt(0).SetIcon(Resource.Drawable.medical_specialist);
            tabLayout.GetTabAt(1).SetIcon(Resource.Drawable.file);
            tabLayout.GetTabAt(2).SetIcon(Resource.Drawable.calendar);
            tabLayout.GetTabAt(3).SetIcon(Resource.Drawable.avatar);
        }

        //to avoid direct app exit on backpreesed and to show fragment from stack
        public override void OnBackPressed()
        {
            if (SupportFragmentManager.BackStackEntryCount != 0)
            {
                SupportFragmentManager.PopBackStack();
            }
            else
            {
                base.OnBackPressed();
            }
        }
    }
}