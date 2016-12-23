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
using ProHealth.Droid.CustomControls;

namespace ProHealth.Droid.ViewHolders
{
    public class SearchDoctorListViewHolder: RecyclerView.ViewHolder
    {
        public ProHealthIconTextView SpecialityLogo { get; private set; }
        public TextView SpecialityCount { get; private set; }
        public TextView Category { get; set; }
        public SearchDoctorListViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            SpecialityLogo = itemView.FindViewById<ProHealthIconTextView>(Resource.Id.sdSpecialityLogo);
            SpecialityCount = itemView.FindViewById<TextView>(Resource.Id.sdSpecialityCount);
            Category = itemView.FindViewById<TextView>(Resource.Id.sdCategory);
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}