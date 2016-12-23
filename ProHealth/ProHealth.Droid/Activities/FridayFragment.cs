using Android.OS;
using Android.Views;
using Android.Widget;

namespace ProHealth.Droid.Fragments.SearchDoctor
{
    public class FridayFragment : BaseFragment
    {
        private ListView buttonsList;

        protected override int FragmentId => Resource.Layout.FridayView;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view=base.OnCreateView(inflater, container, savedInstanceState);
            buttonsList= view.FindViewById<ListView>(Resource.Id.ButtonsList);
            buttonsList.ChoiceMode = ChoiceMode.Single;

            return view;
        }
    }
}