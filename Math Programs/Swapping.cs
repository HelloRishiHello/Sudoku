using System;

namespace Hello_World
{
    class Class6
    {
        public static void swapping()
        {
            int a, b;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            a = (a ^= b);
            b = (b ^= a); 
            a = (a ^= b);
            Console.WriteLine("first number : {0} second number : {1}" , a , b);
        }
    }
}
