using Android.OS;
using Android.Views;

namespace ProHealth.Droid.Fragments.Records
{
    public class RecordsContainerFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.RecordsContainerView;

        protected static int RecordsRoot => Resource.Id.RecordsRoot;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = base.OnCreateView(inflater, container, savedInstanceState);
            return view;
        }
        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            GotoNextFragment<RecordsFragment>(RecordsRoot);
        }
    }
}