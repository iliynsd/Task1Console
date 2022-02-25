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
        
        public static string GetOddNums(string numbers)
       {
           string oddNums = string.Empty;
           string num = String.Empty;
           for (int i=0; i<numbers.Length; i++)
           {
               if (numbers[i] != ';')
               {
                   num += numbers[i];
               }
               else
               {
                   if (Int32.Parse(num) % 2 != 0)
                   {
                       oddNums += num;
                       oddNums += ";";
                   }

                   num = string.Empty;
               }
           }

           return oddNums;
       }


        public static string TryGetOddNums()
        {
            Console.WriteLine("Enter amount of numbers you want to enter");
            var oddNumbers = GetOddNums(InputUtil.EnterListNums(Int32.Parse(InputUtil.TryEnterNum())));
            if (!HasThreeNums(oddNumbers))
            {
                Console.WriteLine("Has not got three odd numbers");
                return TryGetOddNums();
            }

            return oddNumbers;
        }
        
       public static string GetFirstThreeNums(string numbers)
       {
           string firstThreeNums = string.Empty;
           int j = 0;
           for (int i = 0; i < 3; i++)
           {
               for (; j < numbers.Length; j++)
               {
                   if (numbers[j] != ';')
                   {
                       firstThreeNums += numbers[j];
                   }
                   else
                   {
                       firstThreeNums += ";";
                       j++;
                       break;
                   }
               }
           }

           return firstThreeNums;
       }

       public static string GetLastThreeNumsReversed(string numbers)
       {
           string result = string.Empty;
           int count = -1;
           for (int i = numbers.Length - 1; i > -1; i--)
           {
               if (numbers[i] == ';')
               {
                   count++;
                   result += ';';
                   continue;
               }
               
               if (count == 3)
               {
                   result = result.Remove(result.Length - 1); 
                   break;
               }
               
               result += numbers[i];
           }

           return result;
       }

       public static string ReverseString(string data)
       {
           string reverseData = string.Empty;
           for (int i = data.Length-1; i >= 0; i--)
           {
               reverseData += data[i];
           }

           return reverseData;
       }

       public static bool HasThreeNums(string numbers) => numbers.Count(i => i == ';') > 2; 

       public static int SumStringNums(string numbers)
       {
           int result = 0;
           string num = String.Empty;
           for (int i=0; i<numbers.Length; i++)
           {
               if (numbers[i] != ';')
               {
                   num += numbers[i];
               }
               else
               {
                   result += Int32.Parse(num);
                   num = string.Empty;
               }
           }
           
           return result;
       }
    }
}