using Android.OS;
using Android.Views;
using Android.Widget;
using ProHealth.Droid.Activities;
using System;

namespace ProHealth.Droid.Fragments
{
    public class LoginFragment : BaseFragment
    {
        private Button loginButton;

        protected override int FragmentId => Resource.Layout.LoginView;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //HideActionBar();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            Initialize(view);

            return view;
        }

        private void Initialize(View view)
        {
            loginButton = view.FindViewById<Button>(Resource.Id.LoginButton);
            WireEvents();
        }

        private void WireEvents()
        {
            loginButton.Click += OnLoginClick;
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            GotoNextActivity<HomeActivity>();
        }

        public override void OnDestroyView()
        {
            base.OnDestroyView();
            UnWireEvents();
        }

        private void UnWireEvents()
        {
            loginButton.Click -= OnLoginClick;
        }
    }
}