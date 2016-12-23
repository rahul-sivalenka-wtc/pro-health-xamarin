using Android.Content;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using ProHealth.Droid.CustomControls;

namespace ProHealth.Droid.Adapters
{
    public class SchedulePagerAdapter : FragmentPagerAdapter
    {
        private const int DefaultTabWidth = 160;
        private const int TabIconBottomMargin = 5;
        private const int TabIconTopMargin = 5;
        private readonly Fragment[] fragments;

        private readonly ICharSequence[] titles;

        private readonly char[] iconChars;

        private Context context;

        public override int Count => fragments.Length;

        public SchedulePagerAdapter(FragmentManager fm, Fragment[] fragments, ICharSequence[] titles, Context context, char[] iconChars = null) : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
            this.iconChars = iconChars;
            this.context = context;
        }

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return titles[position];
        }

        public View GetTabView(int position)
        {
            View v = LayoutInflater.From(context).Inflate(Resource.Layout.ScheduleCustomTabTemplate, null);
            LinearLayout root = v.FindViewById<LinearLayout>(Resource.Id.TabTemplateRoot);
            TextView titleTv = v.FindViewById<TextView>(Resource.Id.TabText);
            ProHealthIconTextView iconTv = v.FindViewById<ProHealthIconTextView>(Resource.Id.TabIcon);

            var textLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            var iconLayoutParams = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            iconLayoutParams.BottomMargin = TabIconBottomMargin;
            iconLayoutParams.TopMargin = TabIconTopMargin;
            var layoutParams = new TableLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.MatchParent);
            layoutParams.Width = DefaultTabWidth;

            titleTv.LayoutParameters = textLayoutParams;
            iconTv.LayoutParameters = iconLayoutParams;
            root.LayoutParameters = layoutParams;

            titleTv.Text = titles[position].ToString();
            iconTv.Text = iconChars?[position].ToString();

            return v;
        }
    }
}