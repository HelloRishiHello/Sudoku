using System;
namespace HelloWorld
{
    class class13
    {
        public static void Maain(string[] args)
        {
            class13 p2 = new class13();

            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            p2.sorti(arr1);


            //arrayreverse

            //int[] arr2 = new int[10];
            //for (int j = 0; j < arr2.Length; j++)
            //{

            //    arr2[j] = Convert.ToInt32(Console.ReadLine());
            //}
            //p2.reverse(arr2);

            //to get index number

            //int[] arr3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //p2.Toget(arr3, num);

        }

        public void Toget(int[] arr3, int i)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == arr3[j])
                {
                    Console.WriteLine("Index value is = " + j);
                }
            }
        }

        public void reverse(int[] arr2)
        {
            int[] arr3 = new int[10];
            for (int j = 0; j < arr2.Length; j++)
            {
                arr3[j] = arr2[arr2.Length - j - 1];
            }
            foreach(int item in arr3)
            {
                Console.WriteLine(item);
            }
        }

        public void sorti(int[] i)
        {
            int[] sor = i;
            for (int j = 0; j < i.Length; j++)
            {
                for(int k=j+1; k<sor.Length; k++)// 5, 7, 3, 1, 6, 9, 2, 4, 8, 10
                {
                    if(sor[j] > i[k])            // 3,7,5,1,6,9,2,4,8,10 //1,7,5,3,6,9,2,4,8,10 //1,5,7,3,6,9,2,4,8,10 //1,3,7,5,6,9,2,4,8,10
                    {
                        int r = sor[j];          //1,2,7,5,6,9,3,4,8,10//1,2,5,7,6,9,3,4,8,10//1,2,3,7,6,9,5,4,8,10//1,2,3,6,7,9,5,4,8,10//1,2,3,5,7,9,6,4,8,10
                        sor[j] = i[k];           //1,2,3,4,7,9,6,5,8,10//1,2,3,4,6,9,7,5,8,10//1,2,3,4,5,9,7,6,8,10//1,2,3,4,5,7,9,6,8,10//1,2,3,4,5,6,9,7,8,10
                        sor[k] = r;              //1,2,3,4,5,6,7,9,8,10
                        i[k] = r;
                    }
                }
            }
            foreach (int item in sor)
            {
                Console.WriteLine(item);
            }
        }
    }
}
