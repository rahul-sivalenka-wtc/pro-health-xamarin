using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using Java.Lang;
using ProHealth.Droid.Adapters;
using Fragment = Android.Support.V4.App.Fragment;

namespace ProHealth.Droid.Fragments.Schedule
{
    public class ScheduleFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.ScheduleView;

        private TabLayout tabLayout;
        private ViewPager viewPager;

        Fragment[] fragments = new Fragment[] 
        {
            new RemindersFragment(),
            new AppointmentsFragment(),
            new DietFragment(),
            new WorkoutFragment()
        };

        ICharSequence[] titles = CharSequence.ArrayFromStringArray(new[] 
        {
            "Reminders",
            "Appointments",
            "Diet",
            "Workout"
        });

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            InitTabs(view);

            return view;
        }

        private void InitTabs(View view)
        {
            viewPager = view.FindViewById<ViewPager>(Resource.Id.ScheduleViewPager);
            viewPager.Adapter = new SchedulePagerAdapter(ParentActivity.SupportFragmentManager, fragments, titles);

            tabLayout = view.FindViewById<TabLayout>(Resource.Id.ScheduleSlidingTabs);
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