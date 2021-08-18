using System;
using System.Collections.Generic;

namespace StringsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "aa", "bb", "cc" };
            string[] b = new string[] { "cc" };
            string[] c = new string[3];


            var d = new List<string>();

            Console.WriteLine($"array with multipule Array values: {string.Join(',', a)}");
            Console.WriteLine($"array with Array one value: {string.Join(',', b)}");
            Console.WriteLine($"array with Array multipule empty values: {string.Join(',', c)}");
            Console.WriteLine($"array with empty string list: {string.Join(',', d)}");
        }
    }
}
