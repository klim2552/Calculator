using System;
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
            Console.WriteLine("Привет! Я калькулятор. \nЧто бы приступить к работе наберите start, а вот что я шарю))))");
            Console.WriteLine(" Сложение '+' \n Вычитание '-' \n Умножение '*' \n Деление '/' ");
            Console.WriteLine("Так же я уже шарю как находить остаток от деления и некоторые другие темы");
            Console.WriteLine(" Остаток от деления '%' \n Возведение первого числа в степень второго числа 'pow'\n Логическое умножение '&' \n Для того, чтобы сравнить два числа напишите 'bool'");
            string command = Console.ReadLine();
            while (command == "start" || command == "Start" || command == "START" || command == "s" || command == "S")
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
                        Console.Write("Результатом сложения {0} и {1} является {2} \n", numberOne, numberTwo, numberOne + numberTwo);
                        break;
                    case "-":
                        Console.Write("Результатом вычитания {0} и {1} является {2} \n", numberOne, numberTwo, numberOne - numberTwo);
                        break;
                    case "*":
                        Console.Write("Результатом умножения {0} и {1} является {2} \n", numberOne, numberTwo, numberOne * numberTwo);
                        break;
                    case "/":
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("Простите, но на 0 делить нельзя) \n");
                        }
                        else
                        {
                            Console.Write("Результатом деления {0} и {1} является {2} \n", numberOne, numberTwo, numberOne / numberTwo);
                        }
                        break;
                    case "%":
                        Console.Write("Остатком от деления {0} на {1} является {2} \n", numberOne, numberTwo, numberOne % numberTwo);
                        break;
                    case "pow":
                        Console.Write("Результатом возведения числа {0} в степень числа {1} является {2} \n", numberOne, numberTwo, Math.Pow(numberOne, numberTwo));
                        break;
                    case "bool":
                        if (numberOne > numberTwo)
                        {
                            Console.WriteLine("Число {0} больше числа {1} \n", numberOne, numberTwo);
                        }
                        if (numberOne < numberTwo)
                        {
                            Console.WriteLine("Число {0} меньше числа {1} \n", numberOne, numberTwo);
                        }
                        if(numberOne == numberTwo)
                        {
                            Console.WriteLine("Число {0} равно числу {1} \n", numberOne, numberTwo);
                        }
                        break;
                    case "&":
                        Console.WriteLine("Результатом логического умножения числа {0} на число {1} является {2} \n", numberOne, numberTwo, (int)numberOne & (int)numberTwo);
                        break;
                    case "^":
                        Console.WriteLine("Результатом логического вычитания числа {0} и числа {1} является {2} \n", numberOne, numberTwo, (int)numberOne ^ (int)numberTwo);
                        break;
                    case "|":
                        Console.WriteLine("Результатом логического сложения числа {0} и числа {1} является {2} \n", numberOne, numberTwo, (int)numberOne | (int)numberTwo);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                }
            }
            if(command == "exit" || command == "EXIT" || command == "Exit")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Досвидания");
            Console.ReadKey();
        }
    }
}