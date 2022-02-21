using System;

namespace ConsoleApp1.Utils
{
    public static class NumeralsUtil
    {
        public static int CountNumerals(string numbers)
        {
            int result = 0;
            foreach (var num in numbers)
            {
                result += Int32.Parse(num.ToString());
            }
            
            return result;
        }

        public static int FindMaxNumeral(string number)
        {
            int max = CountNumerals(number);
            while (number != "0")
            {
                number = InputUtil.TryEnterNum();
               
                if (CountNumerals(number) > max)
                {
                    max = CountNumerals(number);
                }
            }
           
            return max;
        }
    }
}