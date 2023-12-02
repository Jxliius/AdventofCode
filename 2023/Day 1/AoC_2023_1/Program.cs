using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AoC_2023_1
{
    internal class Program
    {
        static string ReplaceNumberString(string input)
        {
            string[] stringArray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] numberArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Dictionary<string, string> stringToNumberMap = new Dictionary<string, string>();
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringToNumberMap[stringArray[i]] = (i + 1).ToString();
            }

            string smallstring = "";
            string sol = "";
            string checker = "";
            for (int i = 0; i < input.Length; i++)
            {
                smallstring += input[i];
                checker = smallstring;
                foreach (var value in stringToNumberMap)
                {
                    checker = smallstring.Replace(value.Key, value.Value);
                    if (numberArray.Any(checker.Contains))
                    {
                        sol += checker;
                        checker = "";
                        if (char.IsDigit(smallstring[smallstring.Length - 1]))
                        {
                            smallstring = "";
                        }
                        else
                        {
                            smallstring = Convert.ToString(input[i]);
                        }
                    }

                }
            }
            return sol;
        }

        static void Main(string[] args)
        {
            List<string> AllNumbersTest = new List<string>();
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);
            //string[] numbers = new string[] { "two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen" };
            //string[] numbers = new string[4] { "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet" };
            int sol = 0;
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
