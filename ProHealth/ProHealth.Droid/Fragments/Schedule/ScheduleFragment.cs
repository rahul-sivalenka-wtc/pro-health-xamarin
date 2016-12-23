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
        private SchedulePagerAdapter adapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            SetupViewPager(view);

            return view;
        }

        private void SetupViewPager(View view)
        {
            viewPager = view.FindViewById<ViewPager>(Resource.Id.ScheduleViewPager);
            adapter = new SchedulePagerAdapter(ParentActivity.SupportFragmentManager, fragments, titles, ParentActivity, new char[] { 'f', 'g', 'i', 'h' });
            viewPager.Adapter = adapter;

            tabLayout = view.FindViewById<TabLayout>(Resource.Id.ScheduleSlidingTabs);
            tabLayout.SetupWithViewPager(viewPager);

            SetupCustomTabs();
        }

        private void SetupCustomTabs()
        {
            for (int i = 0, count = tabLayout.TabCount; i < count; i++)
            {
                TabLayout.Tab t = tabLayout.GetTabAt(i);
                t.SetCustomView(adapter.GetTabView(i));
            }

            tabLayout.GetTabAt(0)?.Select();
        }
    }
}