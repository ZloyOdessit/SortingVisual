using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 80;
            int height = 30;
            Console.SetWindowSize(width, height);
            Console.CursorVisible = false;

            Random random = new Random();

            int[] array = new int[width];
            int temp;

            for (int i = 0; i < width; i++)
            {
                array[i] = random.Next(0, height - 1);
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                        Console.Clear();
                        Console.SetBufferSize(81, 31);
                        for (int w = 0; w < width; w++)
                        {
                            int barHeight = array[w];
                            Console.BackgroundColor = ConsoleColor.Blue;

                            for (int h = 0; h < barHeight; h++)
                            {
                                Console.SetCursorPosition(w, Console.WindowHeight - h);
                                Console.Write(" ");
                            }
                            Console.ResetColor();
                        }
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
