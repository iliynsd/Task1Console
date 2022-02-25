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

        public static int[] FillArrayInRange(int size)
        {
            var array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = InputUtil.TryEnterNumInRange();
            }

            return array;
        }

        public static IGrouping<int,int> GetMostCommonNumber(int[] array) => array.GroupBy(x => x).OrderByDescending(x => x.Count()).First(); 
        
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

        public static int GetMin(int[] array)
        {
            var min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int GetMax(int[] array)
        {
            var max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int[] GetOddNums(int[] array)
        {
            var oddNums = new int[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddNums[j] = array[i];
                    j++;
                }
            }
            var result = new int[j];
            for (int i = 0; i < j; i++)
            {
                if (oddNums[i] != 0)
                {
                    result[i] = oddNums[i];
                }
            }

            return result;
        }

        public static int[] GetEvenNums(int[] array)
        {
            var evenNums = new int[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNums[j] = array[i];
                    j++;
                }
            }
            var result = new int[j];
            for (int i = 0; i < j; i++)
            {
                if (evenNums[i] != 0)
                {
                    result[i] = evenNums[i];
                }
            }

            return result;
        }

        public static int GetMinNumPosition(int[] array)
        {
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == GetMin(array))
                {
                    position = i;
                    break;
                }
            }

            return position;
        }

        public static int GetMaxNumPosition(int[] array)
        {
            int position = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == GetMax(array))
                {
                    position = i;
                    break;
                }
            }

            return position;
        }

        public static void SwapArrayElements(int[] array, int firstNumInd, int secondNumInd) => (array[firstNumInd], array[secondNumInd]) = (array[secondNumInd], array[firstNumInd]);
        
        public static int[] TryEnterOrderedArray(int size)
        {
            Console.WriteLine("Enter ordered numbers");
            var array = FillArray(size);
            if (!IsOrderedByAscending(array) && !IsOrderedByDescending(array))
            {
                return TryEnterOrderedArray(size);
            }

            return array;
        }
    }
}