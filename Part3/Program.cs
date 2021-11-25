using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Write("1 - проверка числа на четность, 2 - подсчет суммы карт, 3 - проверка простого числа, exit - выход из программы: ");
                string menuNavigation = Console.ReadLine();

                if (menuNavigation == "1")
                {
                    Console.Write("Введите число для проверки:");
                    int number = 0;
                    bool correct = false;

                    correct = int.TryParse(Console.ReadLine(), out number);

                    if (correct)
                    {
                        if (number % 2 == 0)
                            Console.WriteLine($"Число {number} четное");
                        else
                            Console.WriteLine($"Число {number} нечетное");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                else if (menuNavigation == "2")
                {
                    int cardsCount, summ = 0, i = 0;
                    bool correct;

                    Console.WriteLine("Введите количество карт в руке:");
                    correct = int.TryParse(Console.ReadLine(), out cardsCount);

                    if (correct && cardsCount > 0)
                    {
                        do
                        {
                            Console.WriteLine($"Ввежите номинал {i + 1}/{cardsCount} карты:");
                            switch (Console.ReadLine())
                            {
                                case "6":
                                    summ += 6;
                                    i++;
                                    break;
                                case "7":
                                    summ += 7;
                                    i++;
                                    break;
                                case "8":
                                    summ += 8;
                                    i++;
                                    break;
                                case "9":
                                    summ += 9;
                                    i++;
                                    break;
                                case "10":
                                case "J":
                                case "Q":
                                case "K":
                                case "T":
                                    summ += 10;
                                    i++;
                                    break;
                                default:
                                    Console.WriteLine("Повторите ввод!");
                                    break;
                            }
                        }
                        while (i < cardsCount);

                        Console.WriteLine($"У Вас на руках {summ} очков\n");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                else if (menuNavigation == "3")
                {
                    int i = 2, number;
                    bool correct, numState = false;

                    Console.Write("Введите число: ");
                    correct = int.TryParse(Console.ReadLine(), out number);

                    if (correct)
                    {
                        while (i < number - 1)
                        {
                            if (number % i == 0)
                            {
                                numState = true;
                                break;
                            }
                            i++;
                        }

                        if (numState)
                            Console.WriteLine($"Число {number} не является простым");
                        else
                            Console.WriteLine($"Число {number} простое");
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                else if (menuNavigation == "exit")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Повторите ввод\n");
                }
            }
        }

    }
}