using System;
/*
 * Name: Lisa Duong
 * Assignment: Tech Project #3B
 * Date: 9/27/20
 * Class: ISM4300.001
 * Description: Create a C# console application that demonstrates an Array
 */
namespace Duong_TechProj3B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            //manually populated array
            foreach (int i in numbers)
            {
                Console.WriteLine("Element Value = " + i);
            }
                Console.WriteLine("Press any key to exit program...");
            //foreach loop to insert new number for every line
        }
    }
}
