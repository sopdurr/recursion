using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class BossChallenge
    {
        public static List<int> Intersection(List<int> lst1, List<int> lst2)
        {
            if (lst1.Count == 0 || lst2.Count == 0)
            {
                return new List<int>();
            }

            if (lst2.Contains(lst1[0]) && !lst1.GetRange(1, lst1.Count - 1).Contains(lst1[0]))
            {
                return lst1.Where(x => x == lst1[0]).ToList().Concat(Intersection(lst1.GetRange(1, lst1.Count - 1), lst2)).ToList();
            }
            else
            {
                return Intersection(lst1.GetRange(1, lst1.Count - 1), lst2);
            }


        }
    }
}
