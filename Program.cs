using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program start!");
            StreamReader stdin = new StreamReader(@"d:\std.in");
            StreamWriter stdout = new StreamWriter(@"d:\std.out");

            int lenght = int.Parse(stdin.ReadLine());

            int[] mass = new int[lenght];
            for (int i = 0; i < lenght; i++)
            { mass[i] = -1; }
            int max = 0;

            for (int i = 0; i < lenght; i++)
            {
                string[] str = stdin.ReadLine().Split(' ');
                int num = int.Parse(str[1]);

                if (str[0] == "+")
                {
                    mass[i] = num;

                    while (Array.IndexOf(mass, max) >= 0)
                    {
                        max++;
                    }
                    stdout.Write("{0} ", max);
                }
                else
                {
                    int ind = Array.IndexOf(mass, num);
                    mass[ind] = 0 - (1 + mass[ind]);
                    max = 0;
                    while (Array.IndexOf(mass, max) >= 0)
                    {
                        max++;
                    }

                    stdout.Write("{0} ", max);

                }
            }
            stdin.Close();
            stdout.Close();
            Console.WriteLine("Program end!");
        }
    }
}