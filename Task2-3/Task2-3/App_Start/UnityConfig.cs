using System.Web.Http;
using Task2_3.Interfaces;
using Task2_3.Services;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace Task2_3
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IClientService, ClientService>(new HierarchicalLifetimeManager());
            container.RegisterType<IAccountService, AccountService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}