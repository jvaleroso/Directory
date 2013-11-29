using System;
using Directory.Dao;
using Directory.Dao.NHibernate.Dao;
using Directory.Service;
using Directory.Services;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Directory.Web.App_Start
{

    public class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IProvinceDao, ProvinceDao>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICityDao, CityDao>(new ContainerControlledLifetimeManager());
            container.RegisterType<IProvinceService, ProvinceService>(new ContainerControlledLifetimeManager());
            container.RegisterType<ICityService, CityService>(new ContainerControlledLifetimeManager());
        }
    }
}
