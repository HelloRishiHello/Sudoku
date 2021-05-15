using System;


namespace Hello_World
{
    class Class16
    {
        public static void Maain(string[] args)
        {
            Class16 p1 = new Class16();

            //int[] arr1 = new int[10];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //p1.sorting(arr1);


            //int[] arr2 = new int[5];
            //for(int i=0; i<arr2.Length; i++)
            //{
            //    arr2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //p1.Countthebig(arr2);


            int[] arr1 = new int[10] {2,7,6,5,7,3,4,1,9,5 };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            p1.unsortedcount(arr1);

        }

        public void unsortedcount(int[] arr1)
        {
            int count = 0;
            int[] arr2=new int[arr1.Length];
            for(int i=0; i<arr1.Length; i++)         // 1,4,6,4,5
            {
                for (int j = 0; j < arr1.Length; j++)
                { 
                    if (arr1[i] != arr2[j])
                    {
                        if (arr1[i] == arr1[j])
                        {
                            count++;
                            if (count == 1)
                            {
                                arr2[j] = arr1[i];
                            }
                            else
                            {
                                Console.WriteLine($"{arr1[i]} exists in {count} Locations");
                                count = 0;
                            }
                        }
                    }

                }
            }
        }

        public void Countthebig(int[] arr2)
        {
            int bignumber=0, count=0;
            for (int i=0; i < arr2.Length; i++)
            {
                if(bignumber < arr2[i])
                {
                    bignumber = arr2[i];
                    count = 0;
                }
                if(bignumber==arr2[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"{bignumber} is biggest number and exists in {count} times");
        }

        public void sorting(int[] arr1)
        {
            int r = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        r = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = r;
                    }
                }
            }
            Class16 p2 = new Class16();
            p2.searchnumer(arr1);
        }

        public void searchnumer(int[] arr1)
        {
            
            int count = 1,q=0,g=0;
            for (int i = 0; i <= arr1.Length; i++)  
            {

                if (i == arr1.Length-1)
                    {
                        Console.WriteLine($"{arr1[i]} exists in {count} locations "); ///try with single for // count the biigrst no. // unsorted no. count
                        
                        if (count > q)
                        {
                            q = count;
                            g = arr1[i];
                        }
                        goto Final;
                    }
                    if (arr1[i] == arr1[i+1])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{arr1[i]} exists in {count} locations ");
                        if (count > q)
                        {
                            q = count;
                            g=arr1[i];
                        }
                        count = 1;
                    }
            }
            Final :  Console.WriteLine("\n");
                     Console.WriteLine($" {g} is most repeated number that is {q} times "); 
        }
    }
}

