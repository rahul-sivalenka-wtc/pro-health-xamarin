using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Helpers;

namespace ProHealth.Droid.Fragments.SearchDoctor
{
    public class SearchDoctorListFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.SearchDoctorListView;

        private RecyclerView recycler;
        private RecyclerView.LayoutManager layoutMgr;
        private Activity activity;
        private SearchDoctorListAdapter blockAdapter;

        private SearchDoctorInfo reportCategories;
        private View view;

        public SearchDoctorInfo Reportcategories
        {
            get
            {
                if (reportCategories == null)
                    reportCategories = new SearchDoctorInfo();
                return reportCategories;
            }
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = base.OnCreateView(inflater, container, savedInstanceState);
            recycler = initRecycler();
            activity = this.Activity;
            return view;
        }

        private RecyclerView initRecycler()
        {
            //Initialize the RecyclerView
            recycler = view.FindViewById<RecyclerView>(Resource.Id.searchDocterRecycler);
            layoutMgr = new GridLayoutManager(activity, 2);
            reportCategories = new SearchDoctorInfo();
            blockAdapter = new SearchDoctorListAdapter(activity, reportCategories);
            blockAdapter.ItemClick += OnItemClick;
            recycler.SetLayoutManager(layoutMgr);
            recycler.SetAdapter(blockAdapter);
            return recycler;
        }
        public void OnItemClick(object sender, int e)
        {
            Toast.MakeText(activity, "item" + (e + 1), ToastLength.Short).Show();
            GotoNextFragment<DoctorsInfoFragment>(Resource.Id.SearchDoctorRoot);
            //(this.Activity as AppCompatActivity).SupportFragmentManager.BeginTransaction().AddToBackStack("Message").Add(Resource.Id.SearchDoctorFrame, new DoctorsInfoFragment(), " ").Commit();
        }
    }
}