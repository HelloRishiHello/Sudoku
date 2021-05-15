using System;

namespace HelloWorld
{
    class class11
    {
        public static void Maain(string[] args)
        {
            class11 p2 = new class11();
            string[] arr2 = new string[10];
            int[] arr1 = new int[10];
            Console.WriteLine("Enter the student name and marks");
            for (int i = 0; i <= arr2.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine("Name = ");
                    arr2[i] = Console.ReadLine();
                    Console.WriteLine("Marks = ");
                    arr1[j] = Convert.ToInt32(Console.ReadLine());
                    p2.stumarks(arr1[j]);
                }
            }
        }


        public void stumarks(int i)
        {
            if (i >= 35 && i <= 100)
            {
                Console.WriteLine("Congrats You Are Qualified");
            }
            else if (i > 100)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
