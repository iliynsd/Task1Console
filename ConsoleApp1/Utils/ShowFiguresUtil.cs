using System;

namespace ConsoleApp1.Utils
{
    public static class ShowFiguresUtil
    {
        public static void ShowRectangle((int,int) sides)
        {
            for (int i = 0; i < sides.Item2; i++)
            {
                for (int j = 0; j < sides.Item1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void ShowTriangle(int cathet)
        {
            for (int i = 0; i < cathet; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void ShowTurnedTriangle(int cathet)
        {
            for (int i = 0; i < cathet; i++)
            {
                for (int j = cathet; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void ShowTriangleInverted(int cathet)
        {
            for (int i = 0; i < cathet; i++)
            {
                for (int j = cathet; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void ShowTriangleInvertedAndTurned(int cathet)
        {
            for (int i = 0; i < cathet; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = cathet; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
        /*public static void ShowRhombus(int side)
        {
            int center = side / 2;
            for(int i = 0; i < side; i++)
            {
                for(int j = 0; j < side; j++)
                {
                    if(i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j >= center + i - side + 1 && j <= center - i + side - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        */
        public static void ShowRhombus(int side)
        {
            int i, j;
            side = side*2 - 1;
            int center = side / 2;
            for(i = 0; i < side; i++)
            {
                for(j = 0; j < side; j++)
                {
                    if(i <= center)
                    {
                        if (j >= center - i && j <= center + i)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (j >= center + i - side + 1 && j <= center - i + side - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}