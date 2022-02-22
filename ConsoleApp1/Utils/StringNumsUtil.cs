using System;

namespace ConsoleApp1.Utils
{
    public static class StringNumsUtil
    {
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

       public static string GetFirstThreeNums(string numbers)
       {
           string firstThreeNums = string.Empty;
           int j = 0;
           for (int i = 0; i < 3; i++)
           {
               for (; j < numbers.Length - 1; j++)
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

       public static string GetLastThreeNums(string numbers)
       {
           string lastThreeNums = string.Empty;
           int j = numbers.Length - 1;
           for (int i = 0; i < 4;)
           {
               for (; j > -1; j--)
               {
                   if (numbers[j] == ';')
                   {
                       i++;
                   }
                   if(i==3)
                   {
                       lastThreeNums = numbers.Substring(j);
                   }
               }
           }

           return lastThreeNums;
       }

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