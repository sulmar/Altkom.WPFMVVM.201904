using Altkom.ABC.FakeServices;
using Altkom.ABC.FakeServices.Fakers;
using Altkom.ABC.IServices;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.ABC.ViewModels
{
    public class ViewModelLocator
    {
        // Install-Package CommonServiceLocator

        // private IContainer container;

        public ViewModelLocator()
        {
            UseAutoFac();

            // UseSimpleInjector();
        }

        private void UseSimpleInjector()
        {
            var container = new Container();
            container.Register<ICustomersService, FakeCustomersService>();
            
           // ServiceLocator.SetLocatorProvider()

        }

        private static void UseAutoFac()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<CustomersViewModel>();
            builder.RegisterType<FakeCustomersService>().As<ICustomersService>();
            builder.RegisterType<CustomerFaker>();

            IContainer container = builder.Build();

            // Install-Package Autofac.Extras.CommonServiceLocator
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
        }

        public CustomersViewModel CustomersViewModel => ServiceLocator.Current.GetInstance<CustomersViewModel>();

        //public CustomersViewModel CustomersViewModel => container.Resolve<CustomersViewModel>();

        //    => new CustomersViewModel(new FakeCustomersService(new FakeServices.Fakers.CustomerFaker()));



        // Install-Package AutoFac
    }
}
