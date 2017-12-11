using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.OpenText("input.txt");
            int checksum = 0;
            while (!input.EndOfStream)
            {
                string line = input.ReadLine();
                
                var numbers = line.Split('\t').Select(Int32.Parse).ToList();
                int lowest = numbers.Min();
                int bigest = numbers.Max();
                checksum = checksum + (bigest - lowest);
            }
            Console.WriteLine(checksum);
            Console.ReadLine();
        }
    }
}
