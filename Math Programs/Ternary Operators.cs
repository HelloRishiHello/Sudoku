using System;

namespace HelloWorld
{
    class class1
    {
        public static void Maain()
        {
            int a, b, c;
            Console.WriteLine("Enter the first number  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number  ");
            b = Convert.ToInt32(Console.ReadLine());
            c = ((a > b) ? a : b);
            Console.Write(c);
        }
        
    }
}
       