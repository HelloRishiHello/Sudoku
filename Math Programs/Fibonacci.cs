using System;

namespace Hello_World
{
    class Class7
    {
        public static void fibonocci()
        {
            int i=0 , j=1 , sum  , r , num , count=0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0 \n1");
            for (r = 1; r <= num ; r++)
            {
                sum = i + j;

                i = j;
                j = sum;
                Console.WriteLine(sum);
                count++;
            }
            Console.WriteLine("fibonocci numbers count is :-  "+count);
        }
    }
}
