using System;

namespace HelloWorld
{
    class class4
    {
        public static void Mainarmstrong()
        {
            int j = 1,r, c, sum = 0, i,  p, temp;
            Console.WriteLine("Enter the digits");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            i = Convert.ToInt32(Console.ReadLine());
            temp = i;
            while ( j <= p)
            {
                r = i % 10;
                c = r * r * r;
                sum = sum + c;
                i = i / 10;
                j++;
            }
            if (sum == temp)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}