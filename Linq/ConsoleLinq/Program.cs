using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] greeting = { "hello world", "linq", "hello linq", "hello apress" };
            var items =
                from s in greeting
                where s.StartsWith("linq")
                select s;

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
