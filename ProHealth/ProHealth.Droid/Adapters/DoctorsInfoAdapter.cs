using Android.Views;
using Android.Support.V7.Widget;
using ProHealth.Droid.Helpers;
using ProHealth.Droid.ViewHolders;
using System;
using Android.App;
using System.Linq;

namespace ProHealth.Droid.Adapters
{
    public class DoctorsInfoAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;

        // TODO Field region
        public DoctorsInformation doctorsInformation;

        public Activity activity;

        public override int ItemCount
        {
            get
            {
                return DoctorsInformation.DoctorCategories.Count();
            }
        }

        public DoctorsInfoAdapter(DoctorsInformation doctorsInformation, Activity activity)
        {
            this.activity = activity;
            this.doctorsInformation = doctorsInformation;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            DoctorsInfoViewHolder vh = holder as DoctorsInfoViewHolder;
            vh.doctorImage.SetImageResource(doctorsInformation[position].DoctorImageId);
            vh.doctorName.Text = doctorsInformation[position].DoctorName;
            vh.doctorRating.Text = doctorsInformation[position].DoctorRating.ToString();
            vh.doctorFee.Text = doctorsInformation[position].DoctorFee.ToString();
            vh.specialization.Text = doctorsInformation[position].Specialization;
            vh.expertIn.Text = doctorsInformation[position].ExpertIn;
            vh.experience.Text = doctorsInformation[position].Experience.ToString();
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.DoctorsInfoTemplate, parent, false);
            DoctorsInfoViewHolder vh = new DoctorsInfoViewHolder(itemView, OnClick);
            return vh;
        }

        void OnClick(int position)
        {
            ItemClick?.Invoke(this, position);
        }
    }
}