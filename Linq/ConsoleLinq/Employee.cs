using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{
    public class Employee
    {
        public int id;
        public string firstname;
        public string lastname;

        public static ArrayList GetEmployees()
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee { id = 1, firstname = "Joe", lastname = "Rattz" });
            al.Add(new Employee { id = 2, firstname = "William", lastname = "Gates" });
            al.Add(new Employee { id = 1, firstname = "Anders", lastname = "Hejlsberg" });

            return(al);
        }
    }

    public class Contact
    {
        public int id;
        public string Name;

        public static void PublishContacts(Contact[] contacts)
        {
            foreach (Contact c in contacts)
            {
                Console.WriteLine("Contact Id: {0} Contact: {1}", c.id, c.Name);
            }
        }
    }
}
