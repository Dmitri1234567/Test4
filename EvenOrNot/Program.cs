using System;

namespace EvenOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.Read());
            if (a % 2 == 0)
            {
                Console.WriteLine("It is even");
            }
            else
            {
                Console.WriteLine("It isn't even");
            }
        }
    }
}
