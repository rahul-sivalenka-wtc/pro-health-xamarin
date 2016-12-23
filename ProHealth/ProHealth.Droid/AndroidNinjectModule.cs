using Ninject.Modules;
using ProHealth.Core.Services.Interfaces;
using ProHealth.Droid.Services;

namespace ProHealth.Droid
{
    public class AndroidNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IReminderService>().To<ReminderService>();
        }
    }
}