//using System;

//namespace Hello_World
//{
//    class Class10
//    {
//        public static void Main(string[] args)
//        {
//            Class10 p2 = new Class10();
//            int num, x;
//            Console.WriteLine("Enter the Digits");
//            x = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the number");
//            num = Convert.ToInt32(Console.ReadLine());

//            int re = x;
//            int sum = 0;

//            int y = p2.check(num ,  x, sum);


//            if (num == y)
//            {
//                Console.WriteLine("Armstrong Number");
//            }
//            else
//            {
//                Console.WriteLine("Not Armstrong Number");
//            }
//        }
//        public int check(int a ,  int x, int sum)
//        {
//            int re = x;
//            if (x==0)
//            {
//                return sum;
//            }
//            else
//            {
//                int r;
//                r = a % 10;
//                sum = sum + (Convert.ToInt32(Math.Pow(r, re)));
//                a = a / 10;
//                x--;
//                return check(a , x, sum);
//            }
//        }
//    }
//}
using System;
namespace HelloWorld
{
    class class10
    {
        public static void Maain(string[] args)
        {

            int digits;
            int number;
            Console.WriteLine("Enter the Digits");
            digits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            int temp = digits;
            int result = 0;
            class10 p2 = new class10();
            result = result + p2.armstrong(number, digits, result, temp);
            if (number == result)
            {
                Console.WriteLine("armstrong number");
            }
            else
            {
                Console.WriteLine("not armstrong number");
            }
        }



        public int armstrong(int num, int digits, int result, int temp)
        {
           

            if (digits == 0)
            {
                return result;
            }
            else
            {
                int modvalue = num % 10; //8//0//2 //8
                result = result + Convert.ToInt32(Math.Pow(modvalue, temp)); ;//250//500//8208
                int number = num / 10; //820 //82//8//0
                digits = digits - 1; //3 //2//1//0

                return armstrong(number, digits, result, temp);
            }




        }
    }
}

