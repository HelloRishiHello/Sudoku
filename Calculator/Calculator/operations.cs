using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class operations
    {
        public float add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public float sub(int a , int b)
        {
            int c = a - b;
            return c;
        }
        public float multiplication(int a , int b)
        {
            int c = a * b;
            return c;
        }
        public float division(float a , float b)
        {
            float c = a / b;
            return c;
        }
    }
}
