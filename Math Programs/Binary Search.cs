using System;

namespace Hello_World
{
    class bs
    {
        public static void Maain(string[] args)
        {
            bs p1 = new bs();


        
            int[,] arr1 = new int[4, 4] {{ 1, 2, 3, 8 }, { 2 ,3, 4 , 9} ,{ 5, 6, 7, 10 } ,{ 7, 8, 9, 12 } };


            
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            string y = p1.searchnumber(arr1,num);
            Console.WriteLine(y);

        }
        //public string searchnumber(int[,] arr1 , int num)
        //{
        //    for (int i = 0; i < arr1.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arr1.GetLength(1); j++)
        //        {
        //            if (i == j)
        //            {
        //                if (num < arr1[i, j])
        //                {
        //                    for(int k=0; k<=i; k++)
        //                    {
        //                        for(int l=0; l<=i; l++)
        //                        {
        //                            if(num==arr1[k,l])
        //                            {
        //                                return "found";   // doubt = return not working
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return "Not found";
        //}


        public string searchnumber(int[,] arr1, int num)
        {
            int k = arr1.GetLength(0);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (num == arr1[i, j])
                    {
                        return "Found";
                    }
                    else if (num > arr1[i, j])    
                    {
                        i++;
                    }
                    else if (num < arr1[i, j])
                    {
                        k = i;
                        j = 0;
                    }
                }
            }
            return "Not found";
        }
    }
}
