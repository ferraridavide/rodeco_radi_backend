using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodecoRADI.Core
{
    public static class Utils
    {
        public static Guid ParseGuidOrNew(string guid)
        {
            if (Guid.TryParse(guid, out Guid validGuid))
            {
                return validGuid;
            }
            else
            {
                return Guid.NewGuid();
            }
        }
    }
}
