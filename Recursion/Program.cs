using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion
{
    class Program
    {

        static void Main(string[] args)
        {
            //Dæmi 1
            Console.WriteLine("Dæmi 1");
            Console.WriteLine(TrueOrFalse.IsIncreasing(new List<int> { 1, 25, 3, 4, 5 }));
            Console.WriteLine(TrueOrFalse.IsIncreasing(new List<int> { 1, 2, 3, 4, 5 }));

            // Dæmi 2
            List<int> sortList = GreaterThan.FindGreater(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1);
            //List<int> sortList = GreaterThan.FindGreater(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5);
            //List<int> sortList = GreaterThan.FindGreater(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11);
            Console.WriteLine("Dæmi 2");
            foreach (int num in sortList)
            {
                
                Console.WriteLine(num + " ");
            }

            // BOSS CHALLENGE

           // List<int> nums1 = new List<int>() { 1, 2, 3};
           // List<int> nums2 = new List<int>() { 2, 4, 6 };
           // List<int> nums1 = new List<int>() { 1, 2, 3};
           // List<int> nums2 = new List<int>() { 4, 5, 6 };
            List<int> nums1 = new List<int>() { 2, 3, 2, 4 };
            List<int> nums2 = new List<int>() { 2, 2, 4 };

            List<int> solution = BossChallenge.Intersection(nums1, nums2);

            Console.WriteLine("Boss Challenge");
            foreach (int num in solution)
            {
                Console.WriteLine(num + " ");
            }

        }
    }
}

