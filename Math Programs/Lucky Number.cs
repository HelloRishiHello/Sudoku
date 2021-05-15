using System;
namespace helloworld
{
    class class3
    {
        public static void lucky()
        {
            int n, r, sum=0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n >= 9)
            {
                sum = 0;
                while (n > 0)
                {
                    r = n % 10;//5463
                    sum = sum + r;
                    n = n / 10;
                }
                n = sum;
                if(n==9)
                {
                    break;
                }
            }
            if (sum == 9)
            {
                Console.WriteLine("Lucky Number");
            }
            else
            {
                Console.WriteLine("Unlucky Number");
            }
        }
    }
}