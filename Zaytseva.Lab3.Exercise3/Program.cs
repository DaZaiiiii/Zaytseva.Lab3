using System;

namespace Zaytseva.Lab3.Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Январь");
                    break;
                case "2":
                    Console.WriteLine("Февраль");
                    break;
                case "3":
                    Console.WriteLine("Март");
                    break;
                case "4":
                    Console.WriteLine("Апрель");
                    break;
                case "5":
                    Console.WriteLine("Май");
                    break;
                case "6":
                    Console.WriteLine("Июнь");
                    break;
                case "7":
                    Console.WriteLine("Июль");
                    break;
                case "8":
                    Console.WriteLine("Август");
                    break;
                case "9":
                    Console.WriteLine("Сентябрь");
                    break;
                case "10":
                    Console.WriteLine("Октябрь");
                    break;
                case "11":
                    Console.WriteLine("Ноябрь");
                    break;
                case "12":
                    Console.WriteLine("Декабрь");
                    break;

                default:
                    Console.WriteLine("Попробуйте ещё раз: введите номер от 1 до 12");
                    break;
            }
        }
    }
}
