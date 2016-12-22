using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Helpers;
using ProHealth.Droid.Activities;

namespace ProHealth.Droid.Fragments.SearchDoctor
{
    public class DoctorsInfoFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.DoctorsInfoView;
        private RecyclerView recycler;
        private RecyclerView.LayoutManager layoutMgr;
        private Activity activity;
        private DoctorsInfoAdapter blockAdapter;
        private DoctorsInformation doctorsInformation;
        private View view;

        public DoctorsInformation Doctorsinformation
        {
            get
            {
                if (doctorsInformation == null)
                    doctorsInformation = new DoctorsInformation();
                return doctorsInformation;
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
            recycler = view.FindViewById<RecyclerView>(Resource.Id.doctorsRecycler);
            layoutMgr = new LinearLayoutManager(activity);
            doctorsInformation = new DoctorsInformation();
            blockAdapter = new DoctorsInfoAdapter(doctorsInformation, activity);
            blockAdapter.ItemClick += OnItemClick;
            blockAdapter.BookNow += BlockAdapter_BookNow;
            recycler.SetLayoutManager(layoutMgr);
            recycler.SetAdapter(blockAdapter);
            return recycler;
        }

        private void BlockAdapter_BookNow(object sender, System.EventArgs e)
        {
           (Activity as HomeActivity).ShowBottomSheet();
        }

        public void OnItemClick(object sender, int e)
        {
            Toast.MakeText(activity, "item" + (e + 1), ToastLength.Short).Show();
        }

    }

}