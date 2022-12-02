using System;
using System.IO;

namespace AoC_2022_2
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);
            string[] enemy = new string[numbers.Length];
            string[] me = new string[numbers.Length];
            
            for(int i = 0; i < numbers.Length; i++)
            {
                string[]split = numbers[i].Split(' ');
                enemy[i] = split[0];
                me[i] = split[1];
            }
            //Part 1
            int sol = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                //Win
                if (enemy[i][0] == 'A' && me[i][0] == 'Y')
                {
                    sol += 6 + 2;
                }
                else if (enemy[i][0] == 'B' && me[i][0] == 'Z')
                {
                    sol += 6 + 3;
                }
                else if (enemy[i][0] == 'C' && me[i][0] == 'X')
                {
                    sol += 6 + 1;
                }
                //Draw
                else if (enemy[i][0] == 'A' && me[i][0] == 'X') { sol += 3 + 1; }
                else if (enemy[i][0] == 'B' && me[i][0] == 'Y') { sol += 3 + 2; }
                else if (enemy[i][0] == 'C' && me[i][0] == 'Z') { sol += 3 + 3; }
                //Lose
                else if (enemy[i][0] == 'A' && me[i][0] == 'Z')
                {
                    sol += 0 + 3;
                }
                else if (enemy[i][0] == 'B' && me[i][0] == 'X')
                {
                    sol += 0 + 1;
                }
                else if (enemy[i][0] == 'C' && me[i][0] == 'Y')
                {
                    sol += 0 + 2;
                }
            }
            Console.WriteLine("Solution to Part 1 is: " + sol);

            //Part 2
            sol = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                //Win
                if (enemy[i][0] == 'A' && me[i][0] == 'Z')
                {
                    sol += 6 + 2;
                }
                else if (enemy[i][0] == 'B' && me[i][0] == 'Z')
                {
                    sol += 6 + 3;
                }
                else if (enemy[i][0] == 'C' && me[i][0] == 'Z')
                {
                    sol += 6 + 1;
                }
                //Draw
                else if (enemy[i][0] == 'A' && me[i][0] == 'Y') { sol += 3 + 1; }
                else if (enemy[i][0] == 'B' && me[i][0] == 'Y') { sol += 3 + 2; }
                else if (enemy[i][0] == 'C' && me[i][0] == 'Y') { sol += 3 + 3; }
                //Lose
                else if (enemy[i][0] == 'A' && me[i][0] == 'X')
                {
                    sol += 0 + 3;
                }
                else if (enemy[i][0] == 'B' && me[i][0] == 'X')
                {
                    sol += 0 + 1;
                }
                else if (enemy[i][0] == 'C' && me[i][0] == 'X')
                {
                    sol += 0 + 2;
                }
            }
            Console.WriteLine("Solution to Part 2 is: " + sol);


        }
    }
}
