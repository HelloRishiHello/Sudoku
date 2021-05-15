using System;

namespace Hello_World
{
    class Class15
    {
        public static void Maain(string[] args)
        {
            Class15 p1 = new Class15();

            int i, j, num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[2,2];
            Console.WriteLine("Enter the matrix");
            for (i=0; i<arr1.Length-2; i++)
            {
                for(j=0; j<2; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            p1.matnum(arr1,num);
        }

        public void matnum(int[,] arr1, int num)
        {
            int count=0;
            for (int i = 0; i < arr1.Length - 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (num == arr1[i, j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{num} exists in {count} location");
        }
    }
}
