using System;

namespace Hello_World
{
    class Class9
    {
        public static void Maain(string[] args)
        {
            Class9 p1 = new Class9();
            int a;
            int b;
            p1.Add(out a, out b);
            


            //int result = (Convert.ToInt32(Marks.English));
            //Console.WriteLine(result);


            //int x = 20;
            //int y = 10;
            //int c = p1.sub(ref x, ref y);
            //Console.WriteLine("After calling" + c);


            //int num;
            //Console.WriteLine("Enter the number");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (int i=1; i<=num; i++)
            //{
            //    int r = p1.square( i);
            //    Console.WriteLine(r);

            //}




            //p1.factorial();
        }
        public void Add(out int a, out int b)
        {
            a = 100;
            b = 200;
            int d = a - b;
            int c = a + b;
            
        }
        enum Marks
        {
            Maths = 1,
            Science = 2,
            English = 3
        }
        public int sub(ref int a, ref int b)
        {
            int c = a - b;
            return c;
        }
        public int square(int j)
        {
            return j * j;
        }

        public void factorial()
        {
            int i, num, sum = 1;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = num; i >= 1; i--)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);
        }
    }
}
