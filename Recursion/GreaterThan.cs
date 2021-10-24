using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class GreaterThan
    {

        static public List<int> FindGreater(List<int> lst, int n)
        {
            return lst.FindAll(i => i > n);
        }

    }
}
