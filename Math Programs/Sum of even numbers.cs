using System;

namespace Hello_World
{
    class Class5
    {
        public static void even()
        {
            int i, sum=0, num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1; i<=num; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
