using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class TrueOrFalse
    {
        static public bool IsIncreasing(List<int>list)
        {
            if (list.Count < 2)
            {
                return true;
            }

            return list[0] < list[1] && IsIncreasing(list.GetRange(1, list.Count - 1));
        }
    }
}
