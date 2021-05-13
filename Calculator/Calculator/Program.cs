using System;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            restart();
            static void restart()
            {
                int a, b;
                string o;

                operators(out o);
                Firstnumber(out a);
                Secondnumber(out b);

                if (o == "+")
                {
                    operations p1 = new operations();
                    float Ans = p1.add(a, b);
                    Console.WriteLine($"Addition of {a} and {b} is = " + Ans);
                    Console.WriteLine("Type 'y' if you want to continue your calculation or Double press Enter to Exit ");
                    string input = Console.ReadLine();
                    if (input == "y")
                    {
                        restart();
                    }
                }
                if (o == "-")
                {
                    operations p1 = new operations();
                    float Ans = p1.sub(a, b);
                    Console.WriteLine($"Subtraction of {a} and {b} is = " + Ans);
                    Console.WriteLine("Type 'y' if you want to continue your calculation or Double press Enter to Exit ");
                    string input = Console.ReadLine();
                    if (input == "y")
                    {
                        restart();
                    }
                }
                if (o == "*")
                {
                    operations p1 = new operations();
                    float Ans = p1.multiplication(a, b);
                    Console.WriteLine($"Multiplication of {a} and {b} is = " + Ans);
                    Console.WriteLine("Type 'y' if you want to continue your calculation or Double press Enter to Exit ");
                    string input = Console.ReadLine();
                    if (input == "y")
                    {
                        restart();
                    }
                }
                if (o == "/")
                {
                    operations p1 = new operations();
                    float Ans = p1.division(a, b);
                    Console.WriteLine($"Division of {a} and {b} is = " + Ans);
                    Console.WriteLine("Type 'y' if you want to continue your calculation or Double press Enter to Exit ");
                    string input = Console.ReadLine();
                    if (input == "y")
                    {
                        restart();
                    }
                }
            }
        }
        public static string operators(out string o)
        {
            string[] arr = { "+", "-", "*", "/" };
            Console.WriteLine("Enter which operation you want to do = '+','-','*','/'");
            o = Console.ReadLine();
            for(int i=0; i<arr.Length; i++)
            {
                if (o == arr[i])
                {
                    break;
                }
                else if(o != arr[i] && i == arr.Length-1)
                {
                    Console.WriteLine("Print an actual operator");
                    operators(out o);
                }
            }
            return o;
        }
        

        public static int Firstnumber(out int a)
        {
            string wronginput;
            Console.WriteLine("Enter First Value = ");
            wronginput = (Console.ReadLine());
            if (int.TryParse(wronginput, out a) == true)
            {
                a = Convert.ToInt32(wronginput);
            }
            else
            {
                Console.WriteLine("Print an actual number");
                Firstnumber(out a);
            }
            return a;
        }
        public static int Secondnumber(out int b)
        {
            string wronginput;
            Console.WriteLine("Enter Second Value = ");
            wronginput = (Console.ReadLine());
            if (int.TryParse(wronginput, out b) == true)
            {
                b = Convert.ToInt32(wronginput);
            }
            else
            {
                Console.WriteLine("Print an actual number");
                Secondnumber(out b);
            }
            return b;
        }
    }
}

