using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int numberOne = 0;
                int numberTwo = 0;

                Console.WriteLine("Добро пожаловать в самый хреновый калькулятор!\nВведите первое число");

                try
                {
                    numberOne = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ты чё творишь, це не число\nЗапуск ядерных ракет");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Введите второе число");
                try
                {
                    numberTwo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ты чё творишь, це не число\nЗапуск ядерных ракет");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Main();
                }

                Console.WriteLine("Введите символ операции");
                string symbolOperation = Console.ReadLine();
                switch (symbolOperation)
                {
                    case "^":
                        Console.WriteLine(numberOne ^ numberTwo);
                        break;
                    case ":":
                        Console.WriteLine(numberOne / numberTwo);
                        break;
                    case "*":
                        Console.WriteLine(numberOne * numberTwo);
                        break;
                    case "-":
                        Console.WriteLine(numberOne - numberTwo);
                        break;
                    case "+":
                        Console.WriteLine(numberOne + numberTwo);
                        break;
                    default:
                        Console.WriteLine("Я не знаю такую операцию(((");
                        break;
                }
                Console.WriteLine("\nввести цифру '1' - закончить выполнение программы\nвсё остальное - продолжить");
                string cont = Console.ReadLine();
                if (cont == "1")
                {
                    Console.WriteLine("Оцените калькулятор:");
                    string score = Console.ReadLine();
                    Console.WriteLine("Ваша оценка очень важна для нас");
                    break;
                }
            }
        }
    }
}
