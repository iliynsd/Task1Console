using System;
using ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class Program
    {

        public static int SumOfFiniteRow(int num1, int num2, int step = 1)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i+=step)
            {
                sum += i;
            }

            return sum;
        }

        public static int SumOfInFiniteRow(int num, double epsilon = 0.0001)
        {
            int sum = 0;
            for (int i = num; i > epsilon; i+=2)
            {
                sum += i;
            }

            return sum;
        }

        public static int SumOfFiniteRow(int num1, int num2, out int amount)
        {
            int sum = 0;
            amount = 1;
            for (int i = num1; i < num2; i+=4, amount++)
            {
                sum += i;
            }

            return sum;
        }
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter three-digit number");
            //Console.WriteLine(NumeralsUtil.CountNumerals(InputUtil.TryEnterNum()));
           // Console.WriteLine("Enter numbers, 0 - for stop");
            //Console.WriteLine(NumeralsUtil.FindMaxNumeral(InputUtil.TryEnterNum()));
           
          /*  Console.WriteLine("Enter amount of numbers you want to enter");
            var numbers = InputUtil.EnterListNums(Int32.Parse(InputUtil.TryEnterNum()));
            // var numbers = "11;13;7;160;17;11;18;";
            var firstThreeNums = StringNumsUtil.GetFirstThreeNums(StringNumsUtil.GetOddNums(numbers));
            var sumFirstNums = StringNumsUtil.SumStringNums(firstThreeNums);
            Console.WriteLine(sumFirstNums);
            
            
            Console.WriteLine("Enter amount of numbers you want to enter");
            var numbs = InputUtil.EnterListNums(Int32.Parse(InputUtil.TryEnterNum()));
            var lastThreeNums = StringNumsUtil.GetLastThreeNums(StringNumsUtil.GetOddNums(numbs));
            var sumLastNums = StringNumsUtil.SumStringNums(lastThreeNums);
            Console.WriteLine(sumLastNums);
            */
          
          /*Console.WriteLine("Enter num under 20");
          var firstNum = InputUtil.TryEnterNumUnder20();
          Console.WriteLine("Enter num under 20");
          var secondNum = InputUtil.TryEnterNumUnder20();
          (int, int) nums = (Int32.Parse(firstNum), Int32.Parse(secondNum));
          Console.WriteLine($"Rectangle with high - {nums.Item2} and width - {nums.Item1}");
          ShowFiguresUtil.ShowRectangle(nums);
          Console.WriteLine($"Triangles with cathet - {nums.Item1}");
          ShowFiguresUtil.ShowTriangle(nums.Item1);
          ShowFiguresUtil.ShowTurnedTriangle(nums.Item1);
          ShowFiguresUtil.ShowTriangleInverted(nums.Item1);
          ShowFiguresUtil.ShowTriangleInvertedAndTurned(nums.Item1);
          Console.WriteLine($"Rhombus with side - {nums.Item2}");
          ShowFiguresUtil.ShowRhombus(nums.Item2);
          */
          
          Console.WriteLine(SumOfFiniteRow(1,50));
          Console.WriteLine(SumOfFiniteRow(2,50, 2));
          Console.WriteLine(SumOfInFiniteRow(1));
          Console.WriteLine(SumOfFiniteRow(6,46, out int amount));
          Console.WriteLine(amount);
        }
    }
}