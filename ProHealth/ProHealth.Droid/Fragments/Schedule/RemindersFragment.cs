using Android.OS;
using Android.Views;

namespace ProHealth.Droid.Fragments.Schedule
{
    public class RemindersFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.ScheduleRemindersView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            //var dialogInfo = CreateDialog(Resource.Layout.AddReminderDialog, "ReminderDialog");
            //dialogInfo.Dialog.Show(dialogInfo.FragmentTransaction, dialogInfo.DialogTag);

            return view;
        }
    }
}