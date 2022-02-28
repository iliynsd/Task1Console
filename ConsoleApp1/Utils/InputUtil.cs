using System;

namespace ConsoleApp1.Utils
{
    public static class InputUtil
    {
        public static string TryEnterNum()
        {
            var number = Console.ReadLine();
            if (!int.TryParse(number, out int parsedNum) || !IsNumberNotNumerals(number))
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
            if (int.Parse(number) < 21 && int.Parse(number) > 0)
            {
                return number;
            }

            Console.WriteLine("Incorrect input, try again");
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

        public static int TryEnterThreeDigitNum()
        {
            var num = TryEnterNum();
            if (Math.Abs(int.Parse(num)).ToString().Length == 3)
            {
                return int.Parse(num);
            }

            Console.WriteLine("Not three digit num");
            return TryEnterThreeDigitNum();
        }

        public static bool IsNumberNotNumerals(string num) => int.Parse(num).ToString().Length == num.Length;

        public static int TryEnterNaturalNum()
        {
            var number = TryEnterNum();
            if (int.Parse(number) > 0)
            {
                return int.Parse(number);
            }

            Console.WriteLine("Incorrect input, try again");
            return TryEnterNaturalNum();
        }

        public static int TryEnterNumInRange()
        {
            var number = int.Parse(TryEnterNum());
            if (number >= -100 && number <= 100)
            {
                return number;
            }

            Console.WriteLine("Incorrect input, try again");
            return TryEnterNumInRange();
        }

        public static bool TryEnterDirection()
        {
            Console.WriteLine("Enter direction: 0 - left, 1 - right");
            var direction = TryEnterNum();
            if (direction == "0")
            {
                return false;
            }

            if (direction == "1")
            {
                return true;
            }
            
            Console.WriteLine("Incorrect input");
            return TryEnterDirection();
        }
    }
}