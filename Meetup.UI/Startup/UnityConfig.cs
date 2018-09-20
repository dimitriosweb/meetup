using Meetup.UI.Data;
using Meetup.UI.ViewModel;
using Unity;

namespace Meetup.UI.Startup
{
    public static class UnityConfig
    {
        public static MainWindow RegisterComponents()
        {
            IUnityContainer container = new UnityContainer();
            
            container.RegisterType<IFriendDataService, FriendDataService>();
            
            return container.Resolve<MainWindow>();
        }
        
    }
}
