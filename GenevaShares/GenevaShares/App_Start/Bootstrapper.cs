using GenevaShares.Services;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Mvc5;

namespace GenevaShares.App_Start
{
    public static class Bootstrapper
    {

        public static void Run()
        {
            DependencyResolver.SetResolver(Bootstrapper.ConfigureUnityResolver());
        }


        private static IDependencyResolver ConfigureUnityResolver()
        {
            var container = new UnityContainer();

            container.RegisterType<IAuthService, AuthService>();
            container.RegisterType<IEncryptor, SHA256Encyptor>();
            container.RegisterType<IUserService, UserService>();

            return new UnityDependencyResolver(container);
        }
    }
}