using System;
using System.IO;

namespace AoC_2022_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);
            char[] seperators = new char[] { ',', '-' };
            int count = 0;
            //Part 1
            //Split the group
            for (int i = 0; i < numbers.Length; i++)
            {
                string[] split = numbers[i].Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                if (Convert.ToInt32(split[0]) >= Convert.ToInt32(split[2]) && Convert.ToInt32(split[1]) <= Convert.ToInt32(split[3]))
                {
                    count++;
                }
                else if(Convert.ToInt32(split[0]) <= Convert.ToInt32(split[2]) && Convert.ToInt32(split[1]) >= Convert.ToInt32(split[3]))
                {
                    count++;
                }
            }
            Console.WriteLine("sol to first part: " + count);
            //Part 2
            count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                string number1 = "";
                string number2 = "";
                string[] split = numbers[i].Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                for(int u = Convert.ToInt32(split[0]); u < Convert.ToInt32(split[1]) + 1; u++)
                {
                    number1 += "+" + u + "+";
                }
                for(int u = Convert.ToInt32(split[2]); u < Convert.ToInt32(split[3]) + 1; u++)
                {
                    number2 = "+" + u + "+";
                    if (number1.Contains(number2))
                    {
                        count++;
                        break;
                    }
                }
                

            }
            Console.WriteLine("sol to second part " + count);
        }
    }
}
