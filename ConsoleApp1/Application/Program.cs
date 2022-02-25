using System;
using System.Linq;
using ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter three-digit number");
            Console.WriteLine("Sum - " + StringNumsUtil.CountNumerals(InputUtil.TryEnterThreeDigitNum()));

            Console.WriteLine("Enter numbers, 0 - for stop");
            Console.WriteLine("Num with max sum numerals - " + StringNumsUtil.FindNumWithMaxSumNumerals(InputUtil.TryEnterNumNotZero()));


            var firstThreeNums = StringNumsUtil.GetFirstThreeNums(StringNumsUtil.TryGetOddNums());
            var sumFirstNums = StringNumsUtil.SumStringNums(firstThreeNums);
            Console.WriteLine("Sum first three odd nums - " + sumFirstNums);

            var lastThreeNums =
                StringNumsUtil.ReverseString(StringNumsUtil.GetLastThreeNumsReversed(StringNumsUtil.TryGetOddNums()));
            var sumLastNums = StringNumsUtil.SumStringNums(lastThreeNums);
            Console.WriteLine("Sum last three odd nums - " + sumLastNums);


            Console.WriteLine("Enter num under 20");
            var firstNum = InputUtil.TryEnterNumUnder20();
            Console.WriteLine("Enter num under 20");
            var secondNum = InputUtil.TryEnterNumUnder20();
            (int, int) nums = (Int32.Parse(firstNum), Int32.Parse(secondNum));
            Console.WriteLine($"Rectangle with high - {nums.Item2} and width - {nums.Item1}");
            ShowFiguresUtil.ShowRectangle(nums);
            Console.WriteLine($"Triangles with cathet - {nums.Item1}");
            ShowFiguresUtil.ShowTriangle(nums.Item1);
            Console.WriteLine();
            ShowFiguresUtil.ShowTurnedTriangle(nums.Item1);
            Console.WriteLine();
            ShowFiguresUtil.ShowTriangleInverted(nums.Item1);
            Console.WriteLine();
            ShowFiguresUtil.ShowTriangleInvertedAndTurned(nums.Item1);
            Console.WriteLine($"Rhombus with side - {nums.Item2}");
            ShowFiguresUtil.ShowRhombus(nums.Item2);


            Console.Write("Sum of row from 1 to 50 - ");
            Console.WriteLine(RowUtil.SumOfRow(1, 50));
            Console.Write("Sum of row from 2 to 50 with step 2 - ");
            Console.WriteLine(RowUtil.SumOfRow(2, 50, 2));
            Console.Write("Sum of row from 1 to 50 with step 2 - ");
            Console.WriteLine(RowUtil.SumOfRow(1, 50, 2));
            Console.Write("Sum of row 6+10+14 + ... + 46  -  ");
            Console.WriteLine(RowUtil.SumOfRow(6, 46, out int amount));
            Console.Write($"Amount of terms - {amount}");

            Console.Write("Sum of row 6+10+14 + ... (only ten terms) - ");
            Console.WriteLine(RowUtil.SumTenNum(6));
            Console.Write("Sum of row 1+2+4+8+16+... (only eleven terms) - ");
            Console.WriteLine(RowUtil.SumElevenNum(1));
            Console.Write("Sum of row 6+10+14 + ... and stop when sum reach 100  -  ");
            Console.WriteLine(RowUtil.SumUpAndStopAfterHundred(6, out amount));
            Console.WriteLine($"Amount of terms - {amount}");
            Console.Write("Sum of row 6+10+14 + ... and stop when sum reach 100 and return sum before - ");
            Console.WriteLine(RowUtil.SumUpAndStopBeforeHundred(6, out amount));
            Console.WriteLine($"Amount of terms - {amount}");

            Console.WriteLine("Enter amount of fibonacci nums");
            var fibonacciSum = RowUtil.SumFibonacciNums(InputUtil.TryEnterNaturalNum());
            Console.WriteLine($"Sum of Fibonacci nums - {fibonacciSum}");

            Console.WriteLine("--------------First module is end--------------------");

             
            
            Console.WriteLine("Enter array size:");
             var array = ArrayUtil.FillArray(InputUtil.TryEnterNaturalNum());
             Console.WriteLine($"The most common number - {ArrayUtil.GetMostCommonNumber(array).Key}");
             Console.WriteLine($"The amount of most common number - {ArrayUtil.GetMostCommonNumber(array).Count()}");

           
             Console.WriteLine("Enter size of array");
             array = ArrayUtil.FillArray(InputUtil.TryEnterNaturalNum()); 
             Console.WriteLine("Is array order by ascending - " + ArrayUtil.IsOrderedByAscending(array)); 
             Console.WriteLine("Is array ordered by descending - " + ArrayUtil.IsOrderedByDescending(array));
             
             
             Console.WriteLine("Enter size of array");
             array = ArrayUtil.FillArrayInRange(InputUtil.TryEnterNaturalNum());
             
             Console.WriteLine("Min element of array - " + ArrayUtil.GetMin(array));
             Console.WriteLine("Max element of array - " + ArrayUtil.GetMax(array));
             Console.WriteLine("Min odd element - " + ArrayUtil.GetMin(ArrayUtil.GetOddNums(array)));
             Console.WriteLine("Min even element - " + ArrayUtil.GetMin(ArrayUtil.GetEvenNums(array)));
             var minNumPos = ArrayUtil.GetMinNumPosition(array);
             Console.WriteLine("Min num position - " + minNumPos);
             var maxNumPos = ArrayUtil.GetMaxNumPosition(array);
             Console.WriteLine("Max num position - " + maxNumPos);
             ArrayUtil.SwapArrayElements(array, minNumPos, maxNumPos);
             Console.WriteLine("After swap :");
             Console.WriteLine("Min num position - " + ArrayUtil.GetMinNumPosition(array));
             Console.WriteLine("Max num position - " + ArrayUtil.GetMaxNumPosition(array));
             
             Console.WriteLine("Enter size of array");
             ArrayUtil.TryEnterOrderedArray(InputUtil.TryEnterNaturalNum());
        }
    }
}