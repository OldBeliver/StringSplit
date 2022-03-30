using System;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "В краю дремучих ананасов упруго колосились дыни.";

            string[] split = line.Split(' ', '.');

            Console.WriteLine($"{String.Join("\n", split)}");
        }
    }
}
