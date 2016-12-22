using Android.Support.V4.App;
using Java.Lang;

namespace ProHealth.Droid.Adapters
{
    public class SchedulePagerAdapter : FragmentPagerAdapter
    {
        private readonly Fragment[] fragments;

        private readonly ICharSequence[] titles;

        public override int Count => fragments.Length;

        public SchedulePagerAdapter(FragmentManager fm, Fragment[] fragments, ICharSequence[] titles) : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
        }

        public override Fragment GetItem(int position)
        {
            return fragments[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return titles[position];
        }
    }
}