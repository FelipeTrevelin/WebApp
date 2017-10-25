using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using WebApp.Core.Interfaces;
using WebApp.Service;

namespace WebApp
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      container.RegisterType<IUserService, UserService>();
            container.RegisterType<IRepository, WebApp.Repository.Repository>();
            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}