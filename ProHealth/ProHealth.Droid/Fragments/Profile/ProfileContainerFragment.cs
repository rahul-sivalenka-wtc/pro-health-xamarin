using Android.OS;
using Android.Util;
using Android.Views;
using Android.Widget;
using ProHealth.Droid.Extensions;
using System;

namespace ProHealth.Droid.Fragments.Profile
{
    public class ProfileContainerFragment : BaseFragment
    {
        protected override int FragmentId => Resource.Layout.ProfileContainerView;

        private RelativeLayout changePasswordButton;
        private LinearLayout changePasswordLayout;
        private RelativeLayout profileButton;
        private LinearLayout profileLayout;
        private RelativeLayout quickButton;
        private LinearLayout quickLayout;
        private DisplayMetrics displayMetrics = new DisplayMetrics();

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = base.OnCreateView(inflater, container, savedInstanceState);
            profileButton = view.FindViewById<RelativeLayout>(Resource.Id.prProfileButton);
            profileLayout = view.FindViewById<LinearLayout>(Resource.Id.prProfileLayout);

            changePasswordButton = view.FindViewById<RelativeLayout>(Resource.Id.prChangePasswordButton);
            changePasswordLayout = view.FindViewById<LinearLayout>(Resource.Id.prChangePasswordLayout);

            quickButton = view.FindViewById<RelativeLayout>(Resource.Id.prQuickButton);
            quickLayout = view.FindViewById<LinearLayout>(Resource.Id.prQuickLayout);

            WireEvents();
            return view;
        }

        private void WireEvents()
        {
            profileButton.Click += ProfileButton_Click;
            changePasswordButton.Click += ChangePasswordButton_Click;
            quickButton.Click += QuickButton_Click;
            
        }

        private void QuickButton_Click(object sender, EventArgs e)
        {
            if (quickLayout.Visibility == ViewStates.Visible)
                quickLayout.Visibility = ViewStates.Gone;
            else
            {
                StartAnimationForFilteredItems(quickButton, quickLayout);
                quickLayout.Visibility = ViewStates.Visible;
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (changePasswordLayout.Visibility == ViewStates.Visible)
                changePasswordLayout.Visibility = ViewStates.Gone;
            else
            {
                StartAnimationForFilteredItems(changePasswordButton, changePasswordLayout);
                changePasswordLayout.Visibility = ViewStates.Visible;
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            if (profileLayout.Visibility == ViewStates.Visible)
                profileLayout.Visibility = ViewStates.Gone;
            else
            {
                StartAnimationForFilteredItems(profileButton, profileLayout);
                profileLayout.Visibility = ViewStates.Visible;
            }
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
        }

        private void StartAnimationForFilteredItems(RelativeLayout button, LinearLayout layout)
        {
            int[] test2 = new int[2];
            button.GetLocationInWindow(test2);

            float fromY = test2[1];
            var animation = layout.TranslateY(fromY, 0);
            layout.StartAnimation(animation);
        }

    }
}