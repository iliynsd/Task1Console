using System;
using System.IO;
using System.Linq;

namespace ConsoleApp1.Utils
{
    public static class TxtUtil
    {
        private static string PathToTxt => Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\Resources\\Array.txt"));

        public static int[] ReadFile()
        {
            using (var file = new StreamReader(PathToTxt))
            {
                return file.ReadToEnd().Split(';').Select(int.Parse).ToArray();
            }
        } 

        public static void WriteToFile(int[] array)
        {
            using (var file = new StreamWriter(PathToTxt, false))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != array.Length - 1)
                    {
                        file.Write(array[i] + ";");
                    }
                    else
                    {
                        file.Write(array[i]);
                    }
                }
            }
        }
    }
}