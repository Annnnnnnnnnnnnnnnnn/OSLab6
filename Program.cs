using System;
using System.Threading;

namespace lab6OS
{
    class Program
    {
        public static int resultOfSum(int a, int b)
        {
            return a + b;
        }

        public static int func1(int a, int b)
        {
            int res = 0;
            for(int i = 0; i<10; i++)
            {
                Thread.Sleep(1);
                if (i > 8) res = resultOfSum(a, b);
                if (res > 0) return res;
            }
            return res;
        }

        public static int func2(int a, int b)
        {
            int res = 0;
            for (int i = 0; i < 10; i++)
            {
                 res = func1(a, b);
                if (res > 0)
                    return res;
            }

            return res;
        }
        static void Main(string[] args)
        {
            long ellapledTicks = DateTime.Now.Ticks;

            Console.WriteLine("Результат функции:");
            Console.WriteLine(func2(51,110));
            ellapledTicks = DateTime.Now.Ticks - ellapledTicks;
            Console.WriteLine("Потрачено тактов на выполнение: " + ellapledTicks);

        }
    }
}
