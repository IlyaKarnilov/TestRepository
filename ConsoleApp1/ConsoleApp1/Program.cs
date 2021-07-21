using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region firs
            var chocolate = 12.50;
            var coffe = 24.30;
            var milk = 9.99;
            var summ = milk + coffe + chocolate;
            #endregion

            #region second
            int x,y,z;
            x = 12;
            y = x * 3;
            z = x + y;
            #endregion

            #region third
            Console.WriteLine("s1: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("s2: ");
            string s2 = Console.ReadLine();
            Console.WriteLine("s3: ");
            string s3 = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(s1)+Convert.ToInt32(s2));
            Console.WriteLine(Convert.ToInt32(s1) * Convert.ToInt32(s2) * Convert.ToInt32(s3));
            #endregion

        }
    }
}