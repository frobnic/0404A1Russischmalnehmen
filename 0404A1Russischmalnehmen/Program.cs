using System;

namespace _0404A1Russischmalnehmen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int r = 0;

            Console.Write("a :");
            a = int.Parse(Console.ReadLine());

            Console.Write("b :");
            b = int.Parse(Console.ReadLine());

            if (a % 2 == 1)
                r = b;

            do
            {
                a = a / 2;
                b = b * 2;
                if (a % 2 == 1)
                    r = r + b;
                Console.WriteLine("a: {0,4}  b: {1,4}  r: {2,4}", a, b, r);
            } while (a > 1);


        }
    }
}
