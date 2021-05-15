using System;

namespace HelloWorld
{
    class class2
    {
        public static void prime()
        {

            int i, j,   num , r=0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                int count = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
             if(count==2)
                {
                    r++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("No. of prime numbers are : " + r);
        }
    }
}