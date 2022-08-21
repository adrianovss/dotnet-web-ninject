using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_web_ninject.Handler;
using dotnet_web_ninject.Logger;
using Ninject;
using Ninject.Modules;

namespace dotnet_web_ninject.NinjectConfigurations
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomLogger>().To<DatabaseLogger>().WithMetadata("IsDatabaseLogger", true); ;
            Bind<ICustomLogger>().To<EventLogger>().WithMetadata("IsEventLogger", true); ;

            Bind<IHandler>().To<HandlerExample>();
        }
    }
}