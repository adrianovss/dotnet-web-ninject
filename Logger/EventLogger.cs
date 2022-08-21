using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_web_ninject.Logger
{
    public class EventLogger : ICustomLogger
    {
        public void Write(string message)
        {
            Console.WriteLine($"[Event Log]: {message}");
        }
    }
}