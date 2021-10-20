using System;

namespace Zaytseva.Lab3.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Присваиваем х, у и z значения, при которых выражение "f(x, y, z) = z&!x|!z|!y" будет возвращать true
            bool x, y, z;
            NewMethod(out x, out y, out z);
            Console.WriteLine(z & !x | !z | !y); // вышло true

            bool x1 = true, y1 = true, z1 = true;
            Console.WriteLine(z & !x | !z | !y); // вышло true

            bool x2 = false, y2 = false, z2 = true;
            Console.WriteLine(z & !x | !z | !y); // вышло true

            bool x3 = true, y3 = false, z3 = false;
            Console.WriteLine(z & !x | !z | !y); // вышло true

            bool x4 = false, y4 = true, z4 = false;
            Console.WriteLine(z & !x | !z | !y); // вышло true

            bool x5 = true, y5 = true, z5 = false;
            Console.WriteLine(z & !x | !z | !y); // вышло true

            bool x6 = false, y6 = false, z6 = false;
            Console.WriteLine(z & !x | !z | !y); // вышло true
        }
        private static void NewMethod(out bool x, out bool y, out bool z)
        {
            x = false;
            y = false;
            z = false;
        }

    }
}
