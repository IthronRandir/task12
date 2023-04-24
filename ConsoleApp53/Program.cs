using System;

namespace ConsoleApp
{
    class Program
    {
        static void ValidCode(string ISBN10)
        {
            int x12;
            if (ISBN10[12] == 'X') x12 = 10;
            else x12 = ISBN10[12];
            int checSum = ISBN10[0] * 10 + ISBN10[2] * 9 + ISBN10[3] * 8 + ISBN10[4] * 7 + ISBN10[6] * 6 + ISBN10[7] * 5 + ISBN10[8] * 4 + ISBN10[9] * 3 + ISBN10[10] * 2 + x12;

            bool b = checSum % 11 == 0;

            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            string ISBN10 = "3-598-21508-9";
            ValidCode(ISBN10);
        }
    }
}
