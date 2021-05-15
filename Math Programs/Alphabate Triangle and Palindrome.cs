using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Class14
    {
        public static void Maain(string[] args)
        {
            Class14 p3 = new Class14();

            string str;
            str = Console.ReadLine();
            int count = 0;
            p3.palindrome(str , count);
            


            //int num = Convert.ToInt32(Console.ReadLine());

            //p3.alphatria(num);
        }

        public void alphatria(int num)
        {
            char a = 'A';
            for(int i=1; i<=num; i++)
            {
                for(int j=1; j<=num-i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i; k++)
                {
                    Console.Write(a++);
                }
                a--;
                for(int m=1; m<i; m++)
                {
                    Console.Write(--a);
                }
                
                Console.Write("\n");
            }
        }


         public void palindrome(string str , int count)
         {
            for (int k = 0; k < str.Length; k++)
            {
                if (str[str.Length-k-1] == str[k])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                    return;
                }
            }
            if (count == str.Length)
            {
                Console.WriteLine("Palindrome");
            }
        }        
    }
}
