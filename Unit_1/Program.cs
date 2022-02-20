﻿using System;

namespace Unit_1
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int temp;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            foreach (var item in result)
            {
                Console.Write(item);
            }

            return result;
        }
        static string GetDataFromConsole() => Console.ReadLine();
        static string ShowColor(string username)
        {
            Console.WriteLine("{0} Напишите свой любимый цвет на английском с маленькой буквы", username);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }

        static void Main(string[] args)
        {
            //GetArrayFromConsole();
            //Console.WriteLine();

            //var (name, age) = ("Евгения", 27);

            //Console.WriteLine("Мое имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);

            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возрас с цифрами:");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            var favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(anketa.name);
            }

            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }

            Console.ReadLine();
        }
    }
}
