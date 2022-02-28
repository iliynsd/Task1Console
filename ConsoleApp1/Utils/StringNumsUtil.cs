using System;
using System.Linq;

namespace ConsoleApp1.Utils
{
    public static class StringNumsUtil
    {
        public static int CountNumerals(int num)
        {
            int s = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                s += num % 10;
                num /= 10 ;
            }

            return s;
        }

        public static string FindNumWithMaxSumNumerals(string numbers)
        {
            int maxSum = 0;
            string maxNum = String.Empty;
            string num = String.Empty;
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] != ';')
                {
                    num += numbers[i];
                }
                else
                {
                    if (CountNumerals(int.Parse(num)) > maxSum)
                    { 
                        maxSum = CountNumerals(int.Parse(num));
                        maxNum = num;
                    }

                    num = string.Empty;
                }
            }
            
            return maxNum;
        }
        
       public static int SumThreeFirstOddNums(int n)
       {
           int sum = 0;
           for (int i = 0, count = 0; i < n; i++)
           {
               Console.WriteLine("Enter num");
               var num = int.Parse(InputUtil.TryEnterNum());
               if (num % 2 != 0 && count < 3)
               {
                   sum += num;
                   count++;
               }
           }

           return sum;
       }

       public static int SumThreeLastOddNums(int n)
       {
           int n1 = 0;
           int n2 = 0;
           int n3 = 0;
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine("Enter num");
               var num = int.Parse(InputUtil.TryEnterNum());
               if (num % 2 != 0)
               {
                   n1 = n2;
                   n2 = n3;
                   n3 = num;
               }
           }

           return n1 + n2 + n3;
       }
    }
}