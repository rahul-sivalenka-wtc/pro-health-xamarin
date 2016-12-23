using Android.OS;
using Android.Views;

namespace ProHealth.Droid.Fragments.SearchDoctor
{
    public class SearchDoctorContainerFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.SearchDoctorContainerView;

        protected static int SearchDoctorRootFrame => Resource.Id.SearchDoctorRoot;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = base.OnCreateView(inflater, container, savedInstanceState);
            return view;
        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            GotoNextFragment<SearchDoctorListFragment>(SearchDoctorRootFrame);
        }
    }
}