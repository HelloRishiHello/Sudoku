using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    class maxnumber
    {
        public static void Maain(string[] args)
        {
            Console.WriteLine("How many values you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter {n} values");
            List<int> values = new List<int>();
            for(int i=0; i<n; i++)
            {
                values.Add(Convert.ToInt32(Console.ReadLine()));
            }
            maxnumber m1 = new maxnumber();
            int y = m1.maxvalue(values);
            Console.WriteLine("Max number is : " + y);
        }
        public int maxvalue(List<int> values)
        {
            int max = 0;
            for(int i=0; i<values.Count; i++)
            {
                if (max < values[i])
                {
                    max = values[i];
                }
            }
            return max;
        }
    }
}
