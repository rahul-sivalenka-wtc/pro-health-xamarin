using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using ProHealth.Droid.Helpers;
using ProHealth.Droid.ViewHolders;
using System;
using System.Linq;

namespace ProHealth.Droid.Adapters
{
    public class SearchDoctorListAdapter: RecyclerView.Adapter
    {
        // TODO Events region
        public event EventHandler<int> ItemClick;

        // TODO Field region
        public SearchDoctorInfo reportCategories;

        public Activity activity;

        // TODO Properties region
        public override int ItemCount
        {
            get
            {
                return SearchDoctorInfo.MyReportsCategories.Count();
            }
        }

        // TODO Align Ctor, public , override and then private methods.

        // TODO Remove the activity from the adapter.
        public SearchDoctorListAdapter(Activity activity, SearchDoctorInfo reportCategories)
        {
            this.activity = activity;
            this.reportCategories = reportCategories;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SearchDoctorListViewHolder vh = holder as SearchDoctorListViewHolder;
            vh.specialityLogo.SetImageResource(reportCategories[position].IconId);
            vh.specialityCount.Text = reportCategories[position].Count.ToString();
            vh.category.Text = reportCategories[position].Name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.searchDoctorListTemplate, parent, false);
            SearchDoctorListViewHolder vh = new SearchDoctorListViewHolder(itemView, OnClick);
            return vh;
        }

        void OnClick(int position)
        {
            ItemClick?.Invoke(this, position);
        }
    }
}