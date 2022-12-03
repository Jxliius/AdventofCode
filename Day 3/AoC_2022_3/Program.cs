using System;
using System.IO;

namespace AoC_2022_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

            string[] Buchstaben = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

            //Part 1
            int sum = 0;
            string item1 = "";
            string item2 = "";
            for(int i = 0; i < numbers.Length; i++)
            {
                item1 = numbers[i].Substring(0, numbers[i].Length / 2);
                item2 = numbers[i].Substring(numbers[i].Length / 2);

                for(int u = 0; u < Buchstaben.Length; u++)
                {
                    if (item1.Contains(Buchstaben[u]) && item2.Contains(Buchstaben[u]))
                    {
                        sum += u + 1;
                    }
                }
            }
            Console.WriteLine("Sol to Part 1: " + sum);

            //Part 2
            sum = 0;
            string[] groups = new string[3];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                //If one group done make a new one
                if(count > 2)
                {
                    count = 0;
                    //Clear slot 2 so you dont enter the if (Line 50)
                    groups[2] = null; 
                }
                groups[count] = numbers[i];
                count++;
                if (groups[2] != null)
                {
                    for (int u = 0; u < Buchstaben.Length; u++)
                    {
                        if (groups[0].Contains(Buchstaben[u]) && groups[1].Contains(Buchstaben[u]) && groups[2].Contains(Buchstaben[u]))
                        {
                            sum += u + 1;
                        }
                    }
                }
            }
            Console.WriteLine("Sol to Part 2: " + sum);

        }
    }
}
