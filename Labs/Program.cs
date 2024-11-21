using System;
using System.Security.AccessControl;

namespace Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task41();
            Task42();
            TaskD41();
        }

        //Написать программу, которая читает с экрана число от 1 до 365 (номер дня
        //в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
        //февраля(високосный год не учитывать).
        static void Task41()
        {
            Console.WriteLine("Лабораторная 4.1");
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            int dayOfYear = int.Parse(Console.ReadLine());

            int month = 1;
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (dayOfYear > daysInMonth[month - 1])
            {
                dayOfYear -= daysInMonth[month - 1];
                month++;
            }

            Console.WriteLine($"Дата: {dayOfYear} {GetMonthName(month)}");
        }

        static string GetMonthName(int month)
        {
            string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            return monthNames[month - 1];
        }

        //Добавить к задаче из предыдущего упражнения проверку числа введенного
        //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
        //исключение, и выдавать на экран сообщение.
        static void Task42()
        {
            Console.WriteLine("Лабораторная 4.2");
            try
            {
                Console.Write("Введите номер дня в году (от 1 до 365): ");
                int dayOfYear = int.Parse(Console.ReadLine());
                if (dayOfYear < 1 || dayOfYear > 365)
                {
                    throw new ArgumentOutOfRangeException("Число должно быть в диапазоне от 1 до 365.");
                }

                int month = 1;
                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                while (dayOfYear > daysInMonth[month - 1])
                {
                    dayOfYear -= daysInMonth[month - 1];
                    month++;
                }

                Console.WriteLine($"Дата: {dayOfYear} {GetMonthName(month)}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //Изменить программу из упражнений 4.1 и 4.2 так, чтобы она
        //учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
        //делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный
        //год. Однако, если он делится без остатка на 400, это високосный год.)
        static void TaskD41()
        {
            try
            {
                Console.WriteLine("Домашнее задание 4.2");
                Console.Write("Введите год:");
                string yearinput = Console.ReadLine();
                int year;
                if (!int.TryParse(yearinput, out year)) ;
                {
                    Console.Write("Пожалуйста,введите корректное значение:");
                    Console.ReadLine();
                }
                Console.Write("Введите номер дня в году:");
                string dayinput = Console.ReadLine();
                int day;

                if (!int.TryParse(dayinput, out day) || day < 1 || day > (CheckingVis(year) ? 366 : 365))
                {
                    Console.WriteLine($"Номер дня должен быть в диапазоне от 1 до {(CheckingVis(year) ? 366 : 365)}.");
                }
                int month = 1;
                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                while (day > daysInMonth[month - 1])
                {
                    day -= daysInMonth[month - 1];
                    month++;
                }

                Console.WriteLine($"Дата: {day} {GetMonthName(month)}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static bool CheckingVis(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}