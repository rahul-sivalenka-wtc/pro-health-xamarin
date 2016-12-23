using Android.Support.V4.App;
using Java.Lang;

namespace ProHealth.Droid.Adapters
{
    public class HomeViewPagerAdapter : FragmentPagerAdapter
    {
        private Fragment[] fragments;
        private ICharSequence[] titles;

        public HomeViewPagerAdapter(FragmentManager fm, Fragment[] fragments, ICharSequence[] titles) : base(fm)
        {
            this.fragments = fragments;
            this.titles = titles;
        }

        public override int Count => fragments.Length;

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