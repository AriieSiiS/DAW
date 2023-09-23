using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteMachine
{
    static class CMonetary
    {
        public static bool IsCoin(string value)
        {
            bool result = false;
            switch (value)
            {
                case "0,01":
                case "0,02":
                case "0,05":
                case "0,10":
                case "0,20":
                case "0,50":
                case "1,00":
                case "2,00": result = true;break;
            }
            return (result);
        }

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
