using System;
using System.Linq;

namespace ConsoleApp1.Utils
{
    public static class ArrayUtil
    {
        public static int[] FillArray(int size)
        {
            var array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Int32.Parse(InputUtil.TryEnterNum());
            }

            return array;
        }

        public static IGrouping<int,int> GetMostCommonNumber(int[] array) => array.GroupBy(x => x).OrderBy(x => x.Count()).Last();

        public static bool IsOrderedByAscending(int[] array)
        {
            var arraySortedByAsc = array.OrderBy(i => i).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != arraySortedByAsc[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsOrderedByDescending(int[] array)
        {
            var arraySortedByDesc = array.OrderByDescending(i => i).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != arraySortedByDesc[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}