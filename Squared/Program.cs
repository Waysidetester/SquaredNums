using System;
using System.Collections.Generic;

namespace Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();

            List<int> ListToBeSquared = new List<int>();

            List<int> SquaredList = new List<int>();

            int minValue = 1;

            int maxValue = 50;

            int amountOfNumbers = 20;

            for (short i = 0; i < amountOfNumbers; i++)
            {
                ListToBeSquared.Add(randomNum.Next(minValue,maxValue));
            }

            foreach (var number in ListToBeSquared)
            {
                SquaredList.Add((number * number));
            }

            SquaredList.RemoveAll(i => i % 2 != 0);

            foreach (var remainingSquare in SquaredList)
            {
                Console.WriteLine(remainingSquare);
            }

            Console.ReadKey();
        }
    }
}
