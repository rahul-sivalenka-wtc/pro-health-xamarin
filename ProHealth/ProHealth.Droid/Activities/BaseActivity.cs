using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using System;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;
using ProHealth.Droid.Helpers;

namespace ProHealth.Droid.Activities
{
    public abstract class BaseActivity : AppCompatActivity
    {
        protected abstract int ActivityLayoutId { get; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(ActivityLayoutId);
            Typeface.CreateFromAsset(Assets, Constants.ProHealthIconFontPath);
        }

        protected void GotoNextActivity<TActivity>()
        {
            StartActivity(new Intent(Application.Context, typeof(TActivity)));
        }

        protected void GotoNextFragment<TFragment>(int rootId, bool addToBackStack = true)
        {
            var f = Activator.CreateInstance(typeof(TFragment)) as Fragment;

            if (f != null)
            {
                FragmentTransaction tr = SupportFragmentManager.BeginTransaction();
                tr.Replace(rootId, f);
                if(addToBackStack)
                    tr.AddToBackStack(null);
                tr.Commit();
            }
        }
    }
}