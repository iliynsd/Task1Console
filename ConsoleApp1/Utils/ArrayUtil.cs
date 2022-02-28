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
                Console.WriteLine("Enter num");
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
                Console.WriteLine("Array is not ordered");
                return TryEnterOrderedArray(size);
            }

            return array;
        }

        public static int[] MergeAscendingArrays(int[] firstArray, int[] secondArray)
        {
            var arr = new int[firstArray.Length * 2];
            var N = firstArray.Length;
            int i = 0, j = 0, k = 0;
            while (i < N && j < N)
            {
                if (firstArray[i] < secondArray[j])
                {
                    arr[k] = firstArray[i];
                    i++;
                }
                else
                {
                    arr[k] = secondArray[j];
                    j++;
                }
                k++;
            }

            for (; i < N; i++, k++)
            {
                arr[k] = firstArray[i];
            }

            for (; j < N; j++, k++)
            {
                arr[k] = secondArray[j];
            }
            
            return arr;
        }

        public static int[] MergeDescendingArrays(int[] firstArray, int[] secondArray)
        { 
            var N = firstArray.Length;
            var arr = new int[N * 2];
            int i = 0, j = 0, k = 0;
            while (i < N && j < N)
            {
                if (firstArray[i] > secondArray[j])
                {
                    arr[k] = firstArray[i];
                    i++;
                }
                else
                {
                    arr[k] = secondArray[j];
                    j++;
                }
                k++;
            }

            for (; i < N; i++, k++)
            {
                arr[k] = firstArray[i];
            }

            for (; j < N; j++, k++)
            {
                arr[k] = secondArray[j];
            }
            
            return arr;
        }

        public static int[] MergeArrays()
        {
            Console.WriteLine("Enter size of arrays");
            var size = InputUtil.TryEnterNaturalNum();
            Console.WriteLine("Fill 1-st array");
            var firstArray = ArrayUtil.TryEnterOrderedArray(size);
            Console.WriteLine("Fill 2-d array");
            var secondArray = ArrayUtil.TryEnterOrderedArray(size);
            
            if (IsOrderedByAscending(firstArray) && IsOrderedByAscending(secondArray))
            {
                return MergeAscendingArrays(firstArray, secondArray);
            }
            
            if (IsOrderedByDescending(firstArray) && IsOrderedByDescending(secondArray))
            {
                return MergeDescendingArrays(firstArray, secondArray);
            }
            
            return MergeArrays();
        }

        public static void ShowArray(int[] array)
        {
            Console.WriteLine("Array:");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
        }

        public static int[] ShiftArrayInRight(int[] array, int shift)
        {
            int[] result = new int[array.Length];
            int m = 0;
            if (shift > array.Length)
            {
                shift -= array.Length;
            }
            do
            {
                int i = 0; 
                if (shift > 0) 
                {
                    i = array.Length - 1 - m; 
                }
                for (int j = 0; j < result.Length; j++)
                {
                    result[j] = array[i];
                    i++;
                    if (i == array.Length) 
                    {
                        i = 0; 
                    }
                }
                m++; 
            } while (m < shift); 
            
            return result;
        }

        public static int[] ShiftArrayInLeft(int[] array, int shift)
        {
            for (int k = 0; k < shift; k++)
            {
                int first = array[0];
                for (int i = 0; i < array.Length-1; i++)
                {
                    array[i] = array[i+1];
                }
                array[^1] = first;
            }
            
            return array;
        }

        public static int[] ShiftArray(int[] array, int shift, bool direction)
        {
            if (direction)
            {
                return ShiftArrayInRight(array, shift);
            }

            return ShiftArrayInLeft(array, shift);
        }
    }
}