using System;

namespace ConsoleApp1.Utils
{
    public static class StringUtil
    {
        public static void MakeDifferentSentences()
        {
            string hello = "Привет!";
            string name = "Меня зовут ...";
            string age = "Мне ... лет";
            Console.WriteLine("- {0} {1} {2}", hello, name, age);
            Console.WriteLine($"- {hello} {name} {age}");
            var rez = String.Format("- {0} {1} {2}", hello, name, age);
            Console.WriteLine(rez);
            Console.WriteLine("- " + hello + " " + name + " " + age);
        }

        public static void ShowSeparatedByComma(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write(array[i] + ",");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
        }

        public static void ShowLineByLine(string[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }

        public static void CompareStrings(string firstString, string secondString) => Console.WriteLine($"Are equals: {firstString} and {secondString} - {firstString == secondString}");

        public static int FirstOccurrenceIndex(string text, char symbol)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    return i;
                }
            }
            Console.WriteLine($"String does not have this symbol '{symbol}'");
            return -1;
        }

        public static int LastOccurrenceIndex(string text, char symbol)
        {
            for (int i = text.Length - 1; i > -1; i--)
            {
                if (text[i] == symbol)
                {
                    return i;
                }
            }

            Console.WriteLine($"String does not have this symbol '{symbol}'");
            return -1;
        }

        public static string InsertString(int index = 6, string text = "Какой  день", string textToInsert = "замечательный") => text.Insert(index, textToInsert);

        public static string ReplaceString(string text = "Привет, я иду в магазин", string newText = "парк", string oldText = "магазин") => text.Replace(oldText, newText);

        public static string RemoveString(string text = "Сегодня в зоопарке я видел большого жирафа", string textToRemove = "большого") => text.Replace(textToRemove, "");

        public static string[] SplitStringIntoArray(string text) => text.Split(' ');
    }
}