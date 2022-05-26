using System;

namespace DelegatesAndEvents
{
    public delegate int Func1(int a, int b);


    class Program

    {
        public int result;

        static void Main()
        {

            Func1 operation = new Func1(Add);


            int result = DoSomeMath(1, 2, (a, b) => a + b); // 3
            result = DoSomeMath(1, 2, (a, b) => a - b); // -1
            result = DoSomeMath(1, 2, Add);


        }
        static int DoSomeMath(int a, int b, Func1 operation) => operation(a, b);

        public static int Add(int x, int y)
        {
            return x + y;
        }

    }
}
