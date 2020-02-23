using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Solution
{
    public class Printer
    {
        public void DrawPartOne(int n)
        {
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                PrintFirstHalf(n, i);
                PrintFirstHalf(n, i);
                Console.WriteLine();
            }
        }
        public void DrawPartTwo(int n)
        {
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                PrintSecondHalf(n, i);
                PrintSecondHalf(n, i);
                Console.WriteLine();
            }
        }

        private string DrawLine(int length)
        {
            return new string('-',length);
        }
        private string DrawStar(int length)
        {
            return new string('*',length);
        }

        private void PrintFirstHalf(int n, int i)
        {
            Console.Write($"{DrawLine(n - i)}");
            Console.Write($"{DrawStar(n + i * 2)}");
            Console.Write($"{DrawLine(n - i * 2)}");
            Console.Write($"{DrawStar(n + i * 2)}");
            Console.Write($"{DrawLine(n - i)}");
        }
        private void PrintSecondHalf(int n, int i)
        {
            Console.Write($"{DrawLine(n / 2 - i)}");
            Console.Write($"{DrawStar(n)}");
            Console.Write($"{DrawLine(i * 2 + 1)}");
            Console.Write($"{DrawStar((n - i) * 2 - 1)}");
            Console.Write($"{DrawLine(i * 2 + 1)}");
            Console.Write($"{DrawStar(n)}");
            Console.Write($"{DrawLine(n / 2 - i)}");
        }
    }
}
