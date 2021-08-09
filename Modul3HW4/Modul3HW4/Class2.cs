using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class Class2
    {
        public void Run()
        {
            var contactList = new List<Contact>();

            contactList.Add(new Contact { Name = "Валерий", Phone = "0505505055" });
            contactList.Add(new Contact { Name = "Вова", Phone = "0990917586" });
            contactList.Add(new Contact { Name = "Гена", Phone = "0630378924" });
            contactList.Add(new Contact { Name = "Арсений", Phone = "0900934521" });
            contactList.Add(new Contact { Name = "Павел", Phone = "0480027638" });
            contactList.Add(new Contact { Name = "Костя", Phone = "0212030323" });
            contactList.Add(new Contact { Name = "Амир", Phone = "0538390284" });

            var contacts1 = contactList.FirstOrDefault(item => item.Name == "Амир");

            var contacts2 = contactList.Where(item => item.Name.ToUpper().StartsWith("В"));

            var contacts3 = contactList.Select(item => item.Phone).ToArray();

            var contacts4 = contactList.OrderBy(item => item.Name).ThenByDescending(item => item.Phone);

            var contacts5 = contactList.Take(2).Concat(contactList.Skip(2));

            Console.WriteLine("1");
            Console.WriteLine(contacts1.ToString());

            Console.WriteLine("2");
            foreach (var item in contacts2)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("3");
            foreach (var item in contacts3)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("4");
            foreach (var item in contacts4)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("5");
            foreach (var item in contacts5)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
