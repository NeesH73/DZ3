using System;


namespace Tymakov4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 4.1: перевести число в день месяца");
            Console.Write("Введите число[1-365]: ");
            int day = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(1, 1, 1);
            Console.WriteLine($"{day} соответствует: {date.AddDays(day - 1).ToString("dd MMMM")}");



            Console.WriteLine("Упр 4.2: добавить проверку к упр. 4.1");
            Console.Write("Введите число[1-365]: ");
            int day1 = int.Parse(Console.ReadLine());
            if (day1 < 1 || day1 > 365)
            {
                Console.WriteLine(" Вы ввели число меньше 1 или больше 365");
            }
            else
            {
                DateTime date1 = new DateTime(1, 1, 1);
                Console.WriteLine($"{day1} соответствует: {date1.AddDays(day1 - 1).ToString("dd MMMM")}");
            }



            Console.WriteLine("ДЗ 4.1: сделать проверку на високосный год");
            Console.Write("Введите число[1-365]: ");
            int day2 = int.Parse(Console.ReadLine());
            if (day2 < 1 || day2 > 365)
            {
                Console.WriteLine(" Вы ввели число меньше 1 или больше 365");
            }
            else
            {
                DateTime date2 = new DateTime(1, 1, 1);
                Console.WriteLine($"{day2} соответствует: {date2.AddDays(day2 - 1).ToString("dd MMMM")}");
            }
            Console.Write("Введите год: ");
            int year=int.Parse(Console.ReadLine());
            if ((year%4==0 && year%100!=0) || (year%400==0))
            {
                Console.WriteLine($"{year} високосный");
            }
            else 
            {
                Console.WriteLine($"{year} не високосный");
            }









        }
    }
}
