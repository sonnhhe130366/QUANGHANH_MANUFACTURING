using QUANGHANH2.Repositories;
using QUANGHANH2.Repositories.Intefaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace QUANGHANH2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IXincapvattuRepository, XincapvattuRepository>();
            container.RegisterType<IXincapvattuSummaryRepository, XincapvattuSummaryRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}