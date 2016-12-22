using DialogFragment = Android.Support.V4.App.DialogFragment;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;

namespace ProHealth.Droid.Fragments.Dialogs
{
    public class CustomDialogInfo
    {
        public Android.Support.V4.App.FragmentTransaction FragmentTransaction { set; get; }
        public string DialogTag { set; get; }
        public DialogFragment Dialog { set; get; }
    }

    public class CustomDialogFragment : DialogFragment
    {

    }
}