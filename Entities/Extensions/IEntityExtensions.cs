using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Extensions
{
    public static class IEntityExtensions
    {
        public static bool IsObjectNull(this IEntity entity)
        {
            return entity == null;
        }
    }
}
