using System;
using Android.OS;
using Android.Views;

namespace ProHealth.Droid.Fragments.Schedule
{
    public class ScheduleContainerFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.ScheduleContainerView;

        protected static int ScheduleRootFrame => Resource.Id.ScheduleRoot;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            ShowScheduleView();

            return view;
        }

        private void ShowScheduleView()
        {
            GotoNextFragment<ScheduleFragment>(ScheduleRootFrame);
        }
    }
}