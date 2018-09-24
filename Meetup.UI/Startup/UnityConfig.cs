using Meetup.DataAccess;
using Meetup.UI.Data;
using Meetup.UI.ViewModel;
using Prism.Events;
using Unity;
using Unity.Lifetime;

namespace Meetup.UI.Startup
{
    public static class UnityConfig
    {
        public static MainWindow ResolveMainWindow()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());
            container.RegisterType<MeetupDbContext>();
            container.RegisterType<MainWindow>();
            container.RegisterType<MainViewModel>();
            container.RegisterType<IFriendDataService, FriendDataService>();
            container.RegisterType<ILookupDataService, LookupDataService>();
            container.RegisterType<INavigationViewModel, NavigationViewModel>();
            container.RegisterType<IFriendDetailViewModel, FriendDetailViewModel>();

            return container.Resolve<MainWindow>();
        }
        
    }
}
