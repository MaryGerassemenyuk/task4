using System;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string sr = File.ReadAllText(path);
            string[] separators = { " ", "\r\n" };
            string[] mass = sr.Split(separators, StringSplitOptions.None);
            int[] arr = Array.ConvertAll(mass, int.Parse);
            Array.Sort(arr);
            int n = arr.Length / 2;
            int median = arr[n - 1];
            int sum = 0;
            foreach (int elem in arr)

            {
                int mod = Math.Abs(elem - n);
                sum = sum + mod;
            }
            Console.WriteLine(sum);

        }
    }
}
