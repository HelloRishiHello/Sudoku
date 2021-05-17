using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectionss
{
    class findingelement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter how many Values you want to enter : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number you want to find : ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Values : ");
            List<int> values = new List<int>();
            for(int i=0; i<n; i++)
            {
                values.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine(values[..]);
            findingelement f1 = new findingelement();
            f1.elementfinder(values , f);
        }
        public void elementfinder(List<int> values , int f)
        {
            for(int i=0; i<values.Count; i++)
            {
                if(f == values[i])
                {
                    Console.WriteLine($"{f} found at index {i} ");
                }
                if(i == values.Count && f!=values[i])
                {
                    Console.WriteLine("Number not found");
                }
            }
        }
    }
}
