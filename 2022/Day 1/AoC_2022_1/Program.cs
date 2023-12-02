using System;
using System.Collections.Generic;
using System.IO;

namespace AoC_2022_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

            List<int> MostCallories = new List<int>();

            //Part 1
            int summe = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != "")
                {
                    summe += Convert.ToInt32(numbers[i]);
                }
                else
                {
                    MostCallories.Add(summe);
                    summe = 0;
                }
            }
            MostCallories.Sort();
            MostCallories.Reverse();

            Console.WriteLine(MostCallories[0]);
            //Part 2
            int sol = 0;
            sol = MostCallories[0] + MostCallories[1] + MostCallories[2];
            Console.WriteLine(sol);

        }
    }
}