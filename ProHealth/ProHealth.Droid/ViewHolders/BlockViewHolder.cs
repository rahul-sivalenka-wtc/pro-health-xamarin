using System;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace ProHealth.Droid.ViewHolders
{
    public class BlockViewHolder:RecyclerView.ViewHolder
    {
        public ImageView specialityLogo { get; private set; }
        public TextView specialityCount { get; private set; }
        public TextView category { get; set; }
        public BlockViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            specialityLogo = itemView.FindViewById<ImageView>(Resource.Id.specialityLogo);
            specialityCount = itemView.FindViewById<TextView>(Resource.Id.specialityCount);
            category = itemView.FindViewById<TextView>(Resource.Id.category);
            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}