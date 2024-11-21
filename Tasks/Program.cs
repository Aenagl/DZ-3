using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
        //Задание 1.Дана последовательность из 10 чисел. Определить, является ли эта последовательность
        //упорядоченной по возрастанию.В случае отрицательного ответа определить
        //порядковый номер первого числа, которое нарушает данную последовательность.
        //Использовать break.
        static void Task1()
        {
            Console.WriteLine("Задание 1.");
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            bool isOrdered = true; // Флаг, указывающий на упорядоченность

            for (int i = 0; i < numbers.Length - 1; i++) // Length. общее число элементов массива
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"Последовательность не упорядочена. Первое нарушающее число находится на позиции: {i + 2} (число {numbers[i + 1]})");
                    isOrdered = false;
                    break; // Выходим из цикла при первом нарушении
                }
            }
            if (isOrdered)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }

        }
        //Задание 2.Игральным картам условно присвоены следующие порядковые номера в зависимости от
        //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
        //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
        //«девятка» и т. п.). По заданному номеру карты k(6 <=k <= 14) определить достоинство
        //соответствующей карты.Использовать try-catch-finally.

        static void Task2()
        {
            Console.WriteLine("Задание 2.");
            int k;
            Console.Write("Введите порядковый номер карты (6-14):");

            try
            {
                k = Convert.ToInt32(Console.ReadLine());
                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
                }

                string rank;
                switch (k)
                {
                    case 6:
                        rank = "Шестёрка";
                        break;
                    case 7:
                        rank = "Семёрка";
                        break;
                    case 8:
                        rank = "Восьмёрка";
                        break;
                    case 9:
                        rank = "Девятка";
                        break;
                    case 10:
                        rank = "Десятка";
                        break;
                    case 11:
                        rank = "Валет";
                        break;
                    case 12:
                        rank = "Дама";
                        break;
                    case 13:
                        rank = "Король";
                        break;
                    case 14:
                        rank = "Туз";
                        break;
                    default:
                        rank = "Неизвестная карта";
                        break;
                }

                Console.WriteLine($"Достоинство карты: {rank}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
                Console.ReadKey();
            }
        }

        //Задание 3.Напишите программу, которая принимает на входе строку и производит выходные
        //данные в соответствии со следующей таблицей.
        static void Task3()
        {
            Console.WriteLine("Задание 3.");
            Console.Write("Введите строку:");
            string input = Console.ReadLine();
            string output = input.ToLower();
            switch (output)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }

        //Задание 4.Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
        //...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
        //Использовать enum.

        enum DaysOfWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье

        }

        static void Task4()
        {
            Console.WriteLine("Задание 4.");
            Console.Write("Введите номер дня недели:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine(DaysOfWeek.Понедельник);
                    break;
                case 2:
                    Console.WriteLine(DaysOfWeek.Вторник);
                    break;
                case 3:
                    Console.WriteLine(DaysOfWeek.Среда);
                    break;
                case 4:
                    Console.WriteLine(DaysOfWeek.Четверг);
                    break;
                case 5:
                    Console.WriteLine(DaysOfWeek.Пятница);
                    break;
                case 6:
                    Console.WriteLine(DaysOfWeek.Суббота);
                    break;
                case 7:
                    Console.WriteLine(DaysOfWeek.Воскресенье);
                    break;
            }
        }
        //Задание 5.Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
        //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
        //результату.Вывести на экран сколько кукол в “сумке”.

        static void Task5()
        {
            Console.WriteLine("Задание 5.");


            string[] toys = { "Hello Kitty", "Barbie Doll", "Lego", "Ken", "Teddy Bear", "Hello Kitty" };
            int bagCount = 0;
            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie Doll")
                {
                    bagCount++;
                }
            }
            Console.WriteLine($"В сумке кукол: {bagCount}");
        }
    }
}

