using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTest
{
    public static class YieldTest
    {
        public static void outputDivide_foreach_List(int maxNum, int divide)
        {
            foreach (int item in enumerable_List(maxNum, divide))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static IEnumerable<int> enumerable_List(int maxNum, int divide)
        {
            List<int> result = new List<int>();

            for (int currentNum = 1; currentNum <= maxNum; currentNum++)
            {
                if (currentNum % divide != 0) continue;
                result.Add(currentNum);
            }
            return result;
        }
    }
}
