using System;
using Android.Runtime;
using Android.App;
using Ninject;

namespace ProHealth.Droid
{
    [Application(Icon = "@drawable/Icon", Label = "@string/ApplicationName")]
    public class App : Application
    {
        public static IKernel Container { get; set; }

        public App(IntPtr h, JniHandleOwnership jho): base(h, jho)
        {
        }

        public override void OnCreate()
        {
            var kernel = new Ninject.StandardKernel(new AndroidNinjectModule());

            App.Container = kernel;

            base.OnCreate();
        }
    }
}