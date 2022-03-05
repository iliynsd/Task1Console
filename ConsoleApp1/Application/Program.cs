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

           Console.WriteLine("Enter amount of numbers");
           var sumFirstNums = StringNumsUtil.SumThreeFirstOddNums(InputUtil.TryEnterNaturalNum());
           Console.WriteLine("Sum first three odd nums - " + sumFirstNums);

           Console.WriteLine("Enter amount of numbers");
           var sumLastNums = StringNumsUtil.SumThreeLastOddNums(InputUtil.TryEnterNaturalNum());
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
            int amount;
            Console.WriteLine(RowUtil.SumOfRow(6, 46, out amount));
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
             var list = ArrayUtil.GetNumerals(array);
             
             Console.WriteLine($"The most common numeral - {ArrayUtil.GetMostCommonNumeral(list).Key}");
             Console.WriteLine($"The amount of most common numeral - {ArrayUtil.GetMostCommonNumeral(list).Count()}");

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
               Console.WriteLine("After swap min and max element");
               ArrayUtil.ShowArray(array);
               Console.WriteLine();
              
              ArrayUtil.ShowArray(ArrayUtil.MergeArrays());
              Console.WriteLine();
              
              TxtUtil.WriteToFile(TxtUtil.ReadFile().OrderBy(i => i).ToArray());
              TxtUtil.WriteToFile(TxtUtil.ReadFile().OrderByDescending(i => i).ToArray());
  
              Console.WriteLine("Enter size of array:");
              var size = InputUtil.TryEnterNaturalNum();
              array = ArrayUtil.FillArray(size);
              Console.WriteLine("Enter shift");
              var shift = InputUtil.TryEnterNaturalNum();
              var direction = InputUtil.TryEnterDirection();
              var rez = ArrayUtil.ShiftArray(array, shift, direction);
              ArrayUtil.ShowArray(rez);
              Console.WriteLine();
             
             Console.WriteLine("------------STRINGS------------------------");
             
             StringUtil.MakeDifferentSentences();
             
             var arrayStrings = new[] {"apple", "banana", "orange", "kiwi", "mango"};
             StringUtil.ShowSeparatedByComma(arrayStrings);
             Console.WriteLine();
             StringUtil.ShowLineByLine(arrayStrings);
  
             string firstString = "привет";
             string secondString = "здраствуйте";
             StringUtil.CompareStrings(firstString, secondString);
             firstString = "двадцать";
             secondString = "двенадцать";
             StringUtil.CompareStrings(firstString, secondString);
             firstString = "синус";
             secondString = "синусоида";
             StringUtil.CompareStrings(firstString, secondString);
             firstString = "14";
             secondString = "81";
             StringUtil.CompareStrings(firstString, secondString);
  
             string text = "Хорошо в лесу...";
             char symbol = 'о';
             Console.WriteLine(text);
             Console.WriteLine($"Index of first occurrence of '{symbol}' - " + StringUtil.FirstOccurrenceIndex(text, symbol));
  
             text = "Эх, дороги, пыль да туман";
             Console.WriteLine(text);
             Console.WriteLine($"Index of first occurrence of '{symbol}' - " + StringUtil.FirstOccurrenceIndex(text, symbol));
             text = "Семнадцать вариантов решения";
             Console.WriteLine(text);
             Console.WriteLine($"Index of first occurrence of '{symbol}' - " + StringUtil.FirstOccurrenceIndex(text, symbol));
  
             symbol = 'у';
             text = "Где такое интересное место?";
             Console.WriteLine(text);
             Console.WriteLine($"Index of last occurrence of '{symbol}' - " + StringUtil.LastOccurrenceIndex(text, symbol));
             
             text = "У меня дома есть ноутбук.";
             Console.WriteLine(text);
             Console.WriteLine($"Index of last occurrence of '{symbol}' - " + StringUtil.LastOccurrenceIndex(text, symbol));
  
             text = "Винтажный стул";
             Console.WriteLine(text);
             Console.WriteLine($"Index of last occurrence of '{symbol}' - " + StringUtil.LastOccurrenceIndex(text, symbol));
  
             
             Console.WriteLine(StringUtil.InsertString());
             Console.WriteLine(StringUtil.ReplaceString());
             Console.WriteLine(StringUtil.RemoveString());
             text = "ПрыгаЮщие БуквЫ";
             Console.WriteLine(text);
             Console.WriteLine(text.ToLower());
             Console.WriteLine(text.ToUpper());
  
             text = "Первый рабочий день прошел на ура";
             var masBySpliString = StringUtil.SplitStringIntoArray(text);
             StringUtil.ShowLineByLine(masBySpliString);
        }
    }
}