using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Altkom.ABC.WPFClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IIdentity identity = new GenericIdentity("Marcin");
            string[] roles = new string[] { "Administrator", "Developer" };

            IPrincipal principal = new GenericPrincipal(identity, roles);

            Thread.CurrentPrincipal = principal;

            base.OnStartup(e);
        }
    }
}
