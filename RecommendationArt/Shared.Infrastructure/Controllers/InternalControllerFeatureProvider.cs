using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Infrastructure.Controllers
{
    internal class InternalControllerFeatureProvider
    {
        protected override bool IsController(TypeInfo typeInfo)
        {
            if (!typeInfo.IsClass)
            {
                return false;
            }
            if (typeInfo.IsAbstract)
            {
                return false;
            }
            if (typeInfo.ContainsGenericParameters)
            {
                return false;
            }
            if (typeInfo.IsDefined(typeof(NonControllerAttribute)))
            {
                return false;
            }
            return typeInfo.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase) ||
                    typeInfo.IsDefined(typeof(ControllerAttribute));
        }
    }
}
