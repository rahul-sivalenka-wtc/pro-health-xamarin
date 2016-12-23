using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using Java.Lang;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Helpers;

namespace ProHealth.Droid.Fragments.SearchDoctor
{
    public class DoctorsInfoFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.DoctorsInfoView;
        private RecyclerView recycler;
        private RecyclerView.LayoutManager layoutMgr;
        private Activity activity;
        private DoctorsInfoAdapter blockAdapter;
        private BottomSheetBehavior mBottomSheetBehavior;
        private DoctorsInformation doctorsInformation;
        private View view;
        private TabLayout tabLayout;
        private ViewPager viewPager;

        //Fragment[] fragments = new Fragment[] {
        //        new MondayFragment(),
        //        new TuesdayFragment(),
        //        new WednesdayFragment(),
        //        new ThursdayFragment(),
        //        new FridayFragment(),
        //        new SaturdayFragment()
        //     };

        //ICharSequence[] titles = CharSequence.ArrayFromStringArray(new[] {
        //            "M","T","W","T","F","S"
        //        });

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
            View bottomSheet = view.FindViewById(Resource.Id.weeksLayouts);
            bottomSheet.BringToFront();
            mBottomSheetBehavior = BottomSheetBehavior.From(bottomSheet);
            OncreteTabLayout(view);
            recycler = initRecycler();
            activity = this.Activity;
            return view;
        }

        private void OncreteTabLayout(View view)
        {
            //viewPager = view.FindViewById<ViewPager>(Resource.Id.DoctorInfoViewPager);
            //viewPager.Adapter = new HomeViewPagerAdapter(ParentActivity.SupportFragmentManager, fragments, titles);
            //tabLayout = view.FindViewById<TabLayout>(Resource.Id.DoctorInfoSlidingTabs);
            //tabLayout.SetupWithViewPager(viewPager);
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
            //mBottomSheetBehavior.State = BottomSheetBehavior.StateExpanded;
        }

        public void OnItemClick(object sender, int e)
        {
            Toast.MakeText(activity, "item" + (e + 1), ToastLength.Short).Show();
        }

    }

}