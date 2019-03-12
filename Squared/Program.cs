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

            List<int> removeNums = new List<int>();

            foreach (var squaredNum in SquaredList)
            {
                if(squaredNum % 2 != 0)
                {
                    removeNums.Add(squaredNum);
                }
            }

            foreach (var numToRemove in removeNums)
            {
                SquaredList.Remove(numToRemove);
            }

            foreach (var remainingSquare in SquaredList)
            {
                Console.WriteLine(remainingSquare);
            }

            Console.ReadKey();
        }
    }
}
