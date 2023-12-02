using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC_2023_1
{
    internal class Program
    {
        static string ReplaceNumberString(string input)
        {
            return null;
        }

        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            //string[] numbers = System.IO.File.ReadAllLines(path);
            string[] numbers = new string[] { "two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen" };
            //string[] numbers = new string[4] { "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet" };
            int sol = 0;
            //List<string> AllValues = new List<string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                List<string> NumberList = new List<string>();
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    numbers[i] = ReplaceNumberString(numbers[i]);
                    if (char.IsDigit(numbers[i][j]))
                    {
                        NumberList.Add(Convert.ToString(numbers[i][j]));
                    }
                }
                sol += Convert.ToInt32(Convert.ToString(NumberList[0] + NumberList[NumberList.Count - 1]));
            }
            Console.WriteLine(sol);
        }
    }
}
