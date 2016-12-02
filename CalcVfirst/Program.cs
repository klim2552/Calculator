﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать. Я калькулятор. \nЧто бы приступить к работе наберите start, а вот что я шарю))))");
            Console.WriteLine(" Сложение '+' \n Вычитание '-' \n Умножение '*' \n Деление '/' ");
            Console.WriteLine("Так же я уже шарю как находить остаток от деления и некоторые другие темы");
            Console.WriteLine(" Остаток от деления '%' \n Возведение первого числа в степень второго числа '^'\n  Так же можно сравнивать два числа.");
            string command = Console.ReadLine();
            if (command == "start" || command == "Start" || command == "START")
            {
                Console.WriteLine("Хорошо. А теперь введите первый аргумент");
                double numberOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Отлично вы ввели {0}, а теперь добавьте второй аргумент", numberOne);
                double numberTwo = double.Parse(Console.ReadLine());
                Console.WriteLine("Отлично вы ввели {0}, а теперь введите операцию над этими числами", numberTwo);
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.Write("Результатом сложения {0} и {1} является {2}", numberOne, numberTwo, numberOne + numberTwo);
                        break;
                    case "-":
                        Console.Write("Результатом вычитания {0} и {1} является {2}", numberOne, numberTwo, numberOne - numberTwo);
                        break;
                    case "*":
                        Console.Write("Результатом умножения {0} и {1} является {2}", numberOne, numberTwo, numberOne * numberTwo);
                        break;
                    case "/":
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("Простите, но на 0 делить нельзя)");
                        }
                        else
                        {
                            Console.Write("Результатом деления {0} и {1} является {2}", numberOne, numberTwo, numberOne / numberTwo);
                        }
                        break;
                    case "%":
                        Console.Write("Остатком от деления {0} на {1} является {2}", numberOne, numberTwo, numberOne % numberTwo);
                        break;
                    case "^":
                        Console.Write("Результатом возведения числа {0} в степень числа {1} является {2}", numberOne, numberTwo, Math.Pow(numberOne, numberTwo));
                        break;
                    case "bool":
                        if (numberOne > numberTwo)
                        {
                            Console.WriteLine("Число {0} больше числа {1}", numberOne, numberTwo);
                        }
                        if (numberOne < numberTwo)
                        {
                            Console.WriteLine("Число {0} меньше числа {1}", numberOne, numberTwo);
                        }
                        else
                        {
                            Console.WriteLine("Число {0} равно числу {1}", numberOne, numberTwo);
                        }
                        break;
                }
            }
            Console.WriteLine("Досвидания");
            Console.ReadKey();

        }
    }
}