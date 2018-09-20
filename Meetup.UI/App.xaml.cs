using Meetup.UI.Data;
using Meetup.UI.Startup;
using Meetup.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Meetup.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {          
            var mainWindow = UnityConfig.ResolveMainWindow();
            mainWindow.Show();
        }
    }
}
