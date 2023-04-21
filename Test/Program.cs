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
    }
}
