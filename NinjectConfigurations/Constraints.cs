using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninject;
using Ninject.Planning.Bindings;

namespace dotnet_web_ninject.NinjectConfigurations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter,
     AllowMultiple = true, Inherited = true)]
    public class IsEventLogger : ConstraintAttribute
    {
        public override bool Matches(IBindingMetadata metadata)
        {
            return metadata.Has("IsEventLogger") && metadata.Get<bool>("IsEventLogger");
        }
    }

    public class IsDatabaseLogger : ConstraintAttribute
    {
        public override bool Matches(IBindingMetadata metadata)
        {
            return metadata.Has("IsDatabaseLogger") && metadata.Get<bool>("IsDatabaseLogger");
        }
    }
}