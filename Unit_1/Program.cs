using System;

namespace Unit_1_2
{
    class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArray(int[] result)
        {
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

            return result;
        }
        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if (IsSort)
            {
                temp = SortArray(array);
            }
            foreach (var item in temp)
            {
                Console.Write(item + " ");
            }
        }
        static string GetDataFromConsole() => Console.ReadLine();
        static void ShowColor(string username, params string[] favcolors)
        {
            #region
            //Console.WriteLine("{0} {1} лет\nНапишите свой любимый цвет на английском с маленькой буквы", username, userage);
            //var color = Console.ReadLine();

            //switch (color)
            //{
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is red!");
            //        break;

            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is green!");
            //        break;
            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Your color is cyan!");
            //        break;
            //    default:
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.WriteLine("Your color is yellow!");
            //        break;
            //}
            #endregion
            {
                Console.WriteLine("{0} Ваши любимые цвета:", username);
                foreach (var color in favcolors)
                {
                    Console.WriteLine(color);
                }
            }
        }
        static void Main(string[] args)
        {
            #region
            var array = GetArrayFromConsole(10);
            ShowArray(array, true);
            #endregion
            #region
            //(string name, int age) anketa;

            //Console.Write("Введите имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите возрас с цифрами:");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //var favcolor = new string[3];
            //for (int i = 0; i < favcolor.Length; i++)
            //{
            //    Console.WriteLine("{0} {1} лет\nВведите ваш любимый цвет: ", anketa.name, anketa.age);
            //    favcolor[i] = Console.ReadLine();
            //    var color = favcolor[i];
            //    switch (color)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }
            //}

            //ShowColor(anketa.name, favcolor);
            #endregion
            Console.ReadLine();
        }
    }
}