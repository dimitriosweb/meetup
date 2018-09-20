using Meetup.DataAccess;
using Meetup.UI.Data;
using Meetup.UI.ViewModel;
using Unity;

namespace Meetup.UI.Startup
{
    public static class UnityConfig
    {
        public static MainWindow ResolveMainWindow()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<MeetupDbContext>();
            container.RegisterType<IFriendDataService, FriendDataService>();
            
            return container.Resolve<MainWindow>();
        }
        
    }
}
