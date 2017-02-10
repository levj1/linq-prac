using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"Data Source=T1000\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            //Northwnd db = new Northwnd(cs);

            NorthwindDataContext db = new NorthwindDataContext();
            var query = from c in db.Customers
                        select c.City;

            foreach (var cust in query)
            {
                Console.WriteLine(cust);
            }
            

            Console.ReadLine();
        }
    }
}
