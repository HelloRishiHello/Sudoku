using System;

namespace Hello_World
{
    class Class8
    {
        public static void numbertriangle()
        {
            int i, j, k, l, n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)

            {
                for (j = 1; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
