using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using System;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;

namespace ProHealth.Droid.Fragments
{
    public abstract class BaseFragment : Fragment
    {
        protected abstract int FragmentId { get; }

        public AppCompatActivity ParentActivity => (AppCompatActivity)Activity;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(FragmentId, null);
        }

        //protected void HideActionBar()
        //{
        //    ParentActivity.SupportActionBar.Hide();
        //}

        protected void ShowActionBar()
        {
            ParentActivity.SupportActionBar.Show();
        }

        protected void GotoNextActivity<TActivity>()
        {
            ParentActivity.StartActivity(new Intent(Application.Context, typeof(TActivity)));
        }

        protected void GotoNextFragment<TFragment>(int rootId, bool addToBackStack = true)
        {
            var f = Activator.CreateInstance(typeof(TFragment)) as Fragment;

            if (f != null)
            {
                FragmentTransaction tr = ParentActivity.SupportFragmentManager.BeginTransaction();
                tr.Replace(rootId, f);
                if (addToBackStack)
                    tr.AddToBackStack(null);
                tr.Commit();
            }
        }
    }
}