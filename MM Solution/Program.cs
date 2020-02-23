using System;

namespace MM_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Printer print = new Printer();
            print.DrawPartOne(n);
            print.DrawPartTwo(n);
        }
    }
}
