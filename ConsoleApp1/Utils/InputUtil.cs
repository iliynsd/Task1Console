using System;

namespace ConsoleApp1.Utils
{
    public static class InputUtil
    {
        public static string TryEnterNum()
        {
            var number = Console.ReadLine();
            if (!Int32.TryParse(number, out int parsedNum))
            {
                Console.WriteLine("Incorrect input, try again");
                return TryEnterNum();
            }

            return number;
        }
        
        public static string EnterListNums(int amount)
        {
            var numbers = string.Empty;
            for (int i = 0; i < amount; i++)
            {
                numbers += TryEnterNum();
                numbers += ";";
            }

            return numbers;
        }

        public static string TryEnterNumUnder20()
        {
            var number = TryEnterNum();
            if (Int32.Parse(number) < 21)
            {
                return number;
            }

            Console.WriteLine("Too big, try again");
            return TryEnterNumUnder20();
        }

        public static string TryEnterNumNotZero()
        {
            var rez = string.Empty;
            var number = string.Empty;
            do
            {
                number = TryEnterNum();
                if (number != "0")
                {
                    rez += number;
                    rez += ";";
                }
            } while (number != "0");

            return rez;
        }
        
        public static string TryEnter
    }
}