using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using ProHealth.Droid.Adapters;
using ProHealth.Droid.Helpers;

namespace ProHealth.Droid.Fragments.Records
{
    public class RecordsFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.RecordsView;
        private RecyclerView reportsRecycler;
        private RecyclerView.LayoutManager layoutMgr;
        private Activity activity;
        private BlockAdapter blockAdapter;

        private CategoriesOfReports reportCategories;
        private View view;
        private Button prescriptionButton;
        private Button reportsButton;

        public CategoriesOfReports Reportcategories
        {
            get
            {
                if (reportCategories == null)
                    reportCategories = new CategoriesOfReports();
                return reportCategories;
            }
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = base.OnCreateView(inflater, container, savedInstanceState);

            reportsRecycler = initRecycler();

            prescriptionButton = view.FindViewById<Button>(Resource.Id.PrescriptionButton);
            reportsButton = view.FindViewById<Button>(Resource.Id.ReportsButton);

            activity = this.Activity;
            return view;
        }

        private RecyclerView initRecycler()
        {
            //Initialize the RecyclerView
            reportsRecycler = view.FindViewById<RecyclerView>(Resource.Id.BlockRecycler);
            layoutMgr = new GridLayoutManager(activity, 2);
            reportCategories = new CategoriesOfReports();
            blockAdapter = new BlockAdapter(activity, reportCategories);
            blockAdapter.ItemClick += OnItemClick;
            reportsRecycler.SetLayoutManager(layoutMgr);
            reportsRecycler.SetAdapter(blockAdapter);
            return reportsRecycler;
        }
        public void OnItemClick(object sender, int e)
        {
            Toast.MakeText(activity, "item" + (e + 1), ToastLength.Short).Show();
        }
    }
}