using System;

namespace HelloWorld
{
    class program
    {
        public static void addno()
        {
            int i , j , r , sum = 0 , num;
            Console.WriteLine("Enter the length of the number");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= r; j++)
            {
                i = num % 10;
                sum = sum + i;
                num = num / 10;
                
            }
            Console.WriteLine("Addition of abovo. are : "+sum);
      
        }

    }
}