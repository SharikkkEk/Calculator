using System;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numberOne = new Number();

            numberOne.numberByOrder = 1;
            numberOne.count = numberOne.entry();

            Number numberTwo = new Number();

            numberTwo.numberByOrder = 2;
            numberTwo.count = numberTwo.entry();

            Number.operations(numberOne.count, numberTwo.count);

            Console.ReadLine();
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
            Console.WriteLine("Введите символ операции");
            string symbolOperation = Console.ReadLine();

            while (true)
            {
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
