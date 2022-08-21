using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_web_ninject.Logger
{
    public interface ICustomLogger
    {
        void Write(string message);
    }
}