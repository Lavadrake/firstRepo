using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number arrangement
            string numLine = Console.ReadLine();
            int[] numbers = numLine.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int i1 = 0; i1 < numbers.Length - 1; i1++)
                {
                    if (numbers[i1] < numbers[i1 + 1])
                    {
                        int swapVar = numbers[i1];
                        numbers[i1] = numbers[i1 + 1];
                        numbers[i1 + 1] = swapVar;
                    }
                }
            }
            //Logical part
            int oldCounter = 0;
            int newCounter = 0;
            int numCounted = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                    newCounter++;
                else
                {
                    newCounter = 0;
                }
                if (newCounter > oldCounter)
                {
                    numCounted = numbers[i];
                    oldCounter = newCounter;
                }
            }
                Console.WriteLine(numCounted);
        }
    }
}