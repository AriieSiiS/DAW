using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0601_4
{
    static class CMonetary
    {
        public static bool IsMonetary(decimal value)
        {
            bool result = false;
            if (value > 0)
            {
                if (((value * 100) % 1).Equals(0))
                {
                    result = true;
                }
            }
            return (result);
        }

    }
}
