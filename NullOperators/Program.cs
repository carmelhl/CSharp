using System;

namespace NullOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = "line 1";
            string line2 = null;
            var line3 = "";



            Console.WriteLine("line1: {0} ", line1 ?? "line1 evaluted null");
            Console.WriteLine("line2: {0} ", line2 ?? "line2 evaluted null");
            Console.WriteLine("line3: {0} ", line3 ?? "line3 evaluted null");


            var b = new a();

            Console.WriteLine("b.val: {0} ", b?.val);

            b = null;

            Console.WriteLine("b.val: {0} ", b?.val);

        }


    }

    class a 
    {
        public int val { get; set; }
    }
}
