﻿using System;
using ConsoleApp1.Utils;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Enter three-digit number");
          //  Console.WriteLine(StringNumsUtil.CountNumerals(InputUtil.TryEnterThreeDigitNum()));
            
           // Console.WriteLine("Enter numbers, 0 - for stop");
            //Console.WriteLine(StringNumsUtil.FindNumWithMaxSumNumerals(InputUtil.TryEnterNumNotZero()));
            
            /*
            Console.WriteLine("Enter amount of numbers you want to enter");
            var numbers = InputUtil.EnterListNums(Int32.Parse(InputUtil.TryEnterNum()));
            
            var firstThreeNums = StringNumsUtil.GetFirstThreeNums(StringNumsUtil.GetOddNums(numbers));
            Console.WriteLine(firstThreeNums);
            var sumFirstNums = StringNumsUtil.SumStringNums(firstThreeNums);
            Console.WriteLine(sumFirstNums);
*/

            //Console.WriteLine("Enter amount of numbers you want to enter");
          //  var numbs = InputUtil.EnterListNums(Int32.Parse(InputUtil.TryEnterNum()));
          var numbs = "11;10;9;17;171;";
         // var a = StringNumsUtil.GetOddNums(numbs);

          //Console.WriteLine(a);
          Console.WriteLine(StringNumsUtil.ReverseString(StringNumsUtil.GetLastThreeNums(numbs)));
          //var lastThreeNums = StringNumsUtil.GetLastThreeNums(StringNumsUtil.GetOddNums(numbs));
          //Console.WriteLine(lastThreeNums);
          //var sumLastNums = StringNumsUtil.SumStringNums(lastThreeNums);
          //Console.WriteLine(sumLastNums);
/*            
            Console.WriteLine("Enter num under 20");
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
            
            Console.WriteLine(RowUtil.SumOfRow(1, 50));
            Console.WriteLine(RowUtil.SumOfRow(2, 50, 2));
            Console.WriteLine(RowUtil.SumOfRow(1, 50, 2));
            Console.WriteLine(RowUtil.SumOfRow(6, 46, out int amount));
            Console.WriteLine(amount);
            Console.WriteLine(RowUtil.SumTenNum(6));
            Console.WriteLine(RowUtil.SumElevenNum(1));
            Console.WriteLine(RowUtil.SumUpAndStopAfterHundred(6, out amount));
            Console.WriteLine(amount);
            Console.WriteLine(RowUtil.SumUpAndStopBeforeHundred(6, out amount));
            Console.WriteLine(amount);
            Console.WriteLine(RowUtil.SumFibonacciNums(6));
        */

          // Console.WriteLine("--------------First module is end--------------------");

          /* Console.WriteLine("Enter array size:");
           var array = FillArray(Int32.Parse(InputUtil.TryEnterNum()));
           Console.WriteLine($"The most common number - {GetMostCommonNumber(array).Key}");
           Console.WriteLine($"The amount of most common number - {GetMostCommonNumber(array).Count()}");
           
           */
          /* Console.WriteLine("Enter size of array");
           var array = ArrayUtil.FillArray(Int32.Parse(InputUtil.TryEnterNum())); 
           Console.WriteLine(ArrayUtil.IsOrderedByAscending(array)); 
           Console.WriteLine(ArrayUtil.IsOrderedByDescending(array));
           Console.WriteLine("Enter size of array");
           array = ArrayUtil.FillArray(Int32.Parse(InputUtil.TryEnterNum()));*/

        }
    }
}