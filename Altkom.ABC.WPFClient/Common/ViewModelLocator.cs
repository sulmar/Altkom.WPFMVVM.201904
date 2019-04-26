using Altkom.ABC.FakeServices;
using Altkom.ABC.FakeServices.Fakers;
using Altkom.ABC.IServices;
using Altkom.ABC.Models;
using Altkom.ABC.WPFClient.Common;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Bogus;
using CommonServiceLocator;
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

        //private void UseSimpleInjector()
        //{
        //    var container = new Container();
        //    container.Register<ICustomersService, FakeCustomersService>();
            
        //   // ServiceLocator.SetLocatorProvider()

        //}

        private static void UseAutoFac()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<ShellViewModel>();
            //builder.RegisterType<CustomersViewModel>();
            //builder.RegisterType<ProductsViewModel>();

            builder.RegisterAssemblyTypes(typeof(ViewModelBase).Assembly)
                .Where(t=>t.IsSubclassOf(typeof(ViewModelBase)));

            builder.RegisterType<FakeCustomersService>().As<ICustomersService>();
            builder.RegisterType<FakeProductsService>().As<IProductsService>();

            // builder.RegisterType<FrameNavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<ContentControlNavigationService>().As<INavigationService>().SingleInstance();

            builder.RegisterType<CustomerFaker>();
            builder.RegisterType<ProductFaker>();

            IContainer container = builder.Build();

            // Install-Package Autofac.Extras.CommonServiceLocator
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
        }

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();
        public CustomersViewModel CustomersViewModel => ServiceLocator.Current.GetInstance<CustomersViewModel>();
        public ProductsViewModel ProductsViewModel => ServiceLocator.Current.GetInstance<ProductsViewModel>();
        public ProductViewModel ProductViewModel => ServiceLocator.Current.GetInstance<ProductViewModel>();

        //public CustomersViewModel CustomersViewModel => container.Resolve<CustomersViewModel>();

        //    => new CustomersViewModel(new FakeCustomersService(new FakeServices.Fakers.CustomerFaker()));



        // Install-Package AutoFac
    }
}
