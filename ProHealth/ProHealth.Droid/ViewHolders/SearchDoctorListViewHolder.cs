using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace ProHealth.Droid.ViewHolders
{
    public class SearchDoctorListViewHolder: RecyclerView.ViewHolder
    {
        public ImageView specialityLogo { get; private set; }
        public TextView specialityCount { get; private set; }
        public TextView category { get; set; }
        public SearchDoctorListViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            specialityLogo = itemView.FindViewById<ImageView>(Resource.Id.sdSpecialityLogo);
            specialityCount = itemView.FindViewById<TextView>(Resource.Id.sdSpecialityCount);
            category = itemView.FindViewById<TextView>(Resource.Id.sdCategory);
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}