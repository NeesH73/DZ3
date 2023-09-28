using System;


namespace zadachi
{
    internal class Program
    {
        enum cards
        {
            Шестерка = 6,
            Семерка = 7,
            Восьмерка = 8,
            Девятка = 9,
            Десятка = 10,
            Валет = 11,
            Дама = 12,
            Король = 13,
            Туз = 14

        }
        enum days
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: определить последовательность(возр.или нет)");
            int[] mas = new int[10];
            bool flag = true;
            Random randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                mas[i] = randomNumber.Next();
                Console.WriteLine(mas[i] + " ");
            }
            for (int i = 0; i < 9; i++)
            {
                if (mas[i] > mas[i + 1])
                {
                    Console.WriteLine("Последовательность не возр.");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Последовательность возр.");
            }


            Console.WriteLine("Задание 2: определить карту по номеру");
            try
            {
                if (!byte.TryParse(Console.ReadLine(), out byte n) || (n < 6 || n > 14))
                {
                    Console.WriteLine("Введите число от 6 до 14");
                }
                else
                {
                    Console.WriteLine((cards)n);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.WriteLine("Задание 3: Кто вы");
            switch (Console.ReadLine().ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila\n");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol\n");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine\n");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars\n");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal\n");
                    break;
                default:
                    Console.WriteLine("Beer\n");
                    break;
            }


            Console.WriteLine("Задание 4: Вывести день недели");
            try
            {
                if (!byte.TryParse(Console.ReadLine(), out byte dw) || (dw < 1 || dw > 7))
                {
                    Console.WriteLine("Введите число от 1 до 7");
                }
                else
                {
                    Console.WriteLine((days)dw);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.WriteLine("Задание 5: обойти массив и положить в сумку опред. предмет ");
            string[]  Toys= { "Hello Kitty", "Barbie doll", "Bart", "Swer", "Cit", "Hello Kitty", "Canya", "Nero","Larl" ,"Barbie doll", "Nix" };
            byte kol = 0;
            foreach(string Toy in Toys)
            {
                if (Toy == "Barbie doll" || Toy == "Hello Kitty")
                {
                    kol++;
                }
            }
            Console.WriteLine($"В сумке лежит {kol} кукол.");
        }
    }
}
