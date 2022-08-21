using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_web_ninject.Logger;
using dotnet_web_ninject.NinjectConfigurations;

namespace dotnet_web_ninject.Handler
{
    public class HandlerExample : IHandler
    {
        private readonly ICustomLogger _customLogger;
        public HandlerExample([IsEventLogger] ICustomLogger customLogger)
        {
            this._customLogger = customLogger;
        }

        public void Execute()
        {
            this._customLogger.Write("Example logging");
        }

    }
}