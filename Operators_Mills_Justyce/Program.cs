using System;

namespace Operators_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 210 * 2;
            int numberTwo = 33 + 36;
            Console.WriteLine($"the max of {numberOne} and {numberTwo} is {Math.Max(numberOne, numberTwo)}");
            Console.WriteLine($"the min of {numberOne} and {numberTwo} is {Math.Min(numberOne, numberTwo)}");
            double numberThree = 3.5 * 62;
            double numberFour = 76.3 + 41.9;
            Console.WriteLine($"the max of {numberThree} and {numberFour} is {Math.Max(numberThree, numberFour)}");
            Console.WriteLine($"the min of {numberThree} and {numberFour} is {Math.Min(numberThree, numberFour)}");
            decimal numberFive = 98.5m * 56.2;
            decimal numberSix = 56.74m + 78.32m;
            Console.WriteLine($"the max of {numberFive} and {numberSix} is {Math.Max(numberFive, numberSix)}");
            Console.WriteLine($"the min of {numberFive} and {numberSix} is {Math.Min(numberFive, numberSix)}");
        }
    }
}
