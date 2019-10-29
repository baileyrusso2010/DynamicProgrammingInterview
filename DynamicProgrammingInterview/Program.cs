using System;

namespace DynamicProgrammingInterview
{
    class MainClass
    {
        public static int x = 100;
        public static int[] mono = new int[x + 1];

        public static void Main(string[] args)
        {
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fib(x));

        }


        public static int Fib(int x)
        {
            int result;

            if (mono[x] != 0)
                return mono[x];

            if (x == 0 || x == 1)
                result = 1;
            else
                result = Fib(x - 1) + Fib(x - 2);

            mono[x] = result;
            return result;

        }//end of fib

    }//end of class
}//end of namespace
