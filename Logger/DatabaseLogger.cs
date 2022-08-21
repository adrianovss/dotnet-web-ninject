using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_web_ninject.Logger
{
    public class DatabaseLogger : ICustomLogger
    {
        public void Write(string message)
        {
            Console.WriteLine($"[Database Log]: {message}");
        }
    }
}