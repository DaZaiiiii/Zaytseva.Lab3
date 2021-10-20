using System;

namespace Zaytseva.Lab3.Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во месяцев от 1 до 1199:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Возраст в целых годах составляет:" + 1 + "месяц");
                    break;
                case "2":
                    Console.WriteLine("Возраст в целых годах составляет:" + 2 + "месяца");
                    break;
                default:
                    Console.WriteLine("Повторите попытку");
                    break;
            }

        }
    }
}
using System;

namespace пример
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заданные атрибуты
            // Возраст в годах и месяцах, месяцы, года
            int age;
            double year;
            int month;

            // Ввод информации в программу.
            Console.WriteLine("Введите возраст в месяцах от 1 до 1199:");
            string xstr = Console.ReadLine();
            double x = Convert.ToDouble(xstr);

            if (0 < x & x <= 1199)
            { }
            else { Console.WriteLine("Попробуйте снова. Ввведите возраст в месяцах от 1 до 1199:"); return if}

        }

        year = x / 12;
        month = age % 12;


}
}