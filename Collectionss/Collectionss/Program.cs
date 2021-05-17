using System;
using System.Collections.Generic;

namespace Collectionss
{
    class additionofnum
    {
        public static void Maain(string[] args)
        {
            int sum=0;
            Console.Write("Enter how many numbers you want to add : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Values");
            List<int> values = new List<int>();
            for(int i=0; i<n; i++)
            {
                values.Add(Convert.ToInt32(Console.ReadLine()));
                sum = sum + values[i];
            }
            Console.WriteLine("Sum is : " + sum);
        }
    }
}
