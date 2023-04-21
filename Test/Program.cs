using System;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Number numberOne = new Number();

                numberOne.numberByOrder = 1;
                numberOne.count = numberOne.entry();

                Number numberTwo = new Number();

                numberTwo.numberByOrder = 2;
                numberTwo.count = numberTwo.entry();

                Number.operations(numberOne.count, numberTwo.count);

                Console.WriteLine("Продолжить вычисления?\nY - да\nN - нет");

                ConsoleKeyInfo choice = Console.ReadKey();
                switch (choice.KeyChar)
                {
                    case 'y':
                        Console.WriteLine("\n");
                        break;
                    case 'n':
                        return;
                    default:
                        Console.WriteLine("Я таких кнопок не знаю, так что продолжаю\n");
                        break;
                }
            }
        }
    }
    
    public class Number
    {
        public int count;

        public int numberByOrder;

        public int entry()
        {
            Console.WriteLine($"Введите {numberByOrder} число");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out count) == false)
                {
                    Console.WriteLine("Введите число заново");
                    continue;
                }
                else
                {
                    return count;
                }
            }
        }

        public static void operations(int numberOne, int numberTwo)
        {
            while (true)
            {
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
                        Console.WriteLine("Я знаю лишь операции: '^'; ':'; '*'; ; '-'; '+' ");
                        continue;
                }
                break;
            }
        }
    }
}
