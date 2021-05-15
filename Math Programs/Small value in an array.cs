using System;

namespace Hello_World
{
    class Class12
    {
        public static void Maain(string[] args)
        {
            Class12 p5 = new Class12();

            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            p5.minval(arr1);
        }

        public void minval(int[] i)
        {
            int min = i[0];
            for (int j = 0; j < i.Length; j++)
            {
                if (min < i[j])
                {
                    min = i[j];
                }
            }
            Console.WriteLine("maximum value is = " + min);
        }
    }
}
