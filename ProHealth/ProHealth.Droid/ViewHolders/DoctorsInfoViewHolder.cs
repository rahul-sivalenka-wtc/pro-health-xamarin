using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace ProHealth.Droid.ViewHolders
{
    public class DoctorsInfoViewHolder : RecyclerView.ViewHolder
    {
        public ImageView doctorImage { get; set; }
        public TextView doctorName { get; set; }
        public TextView doctorRating { get; set; }
        public TextView doctorFee { get; set; }
        public TextView experience { get; set; }
        public TextView expertIn { get; set; }
        public TextView specialization { get; set; }

        public DoctorsInfoViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            doctorImage = itemView.FindViewById<ImageView>(Resource.Id.doctorImage);
            doctorName = itemView.FindViewById<TextView>(Resource.Id.doctorName);
            doctorRating = itemView.FindViewById<TextView>(Resource.Id.rating);
            doctorFee = ItemView.FindViewById<TextView>(Resource.Id.doctorFee);
            experience = ItemView.FindViewById<TextView>(Resource.Id.experience);
            expertIn = ItemView.FindViewById<TextView>(Resource.Id.expertIn);
            specialization = ItemView.FindViewById<TextView>(Resource.Id.specialization);
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}