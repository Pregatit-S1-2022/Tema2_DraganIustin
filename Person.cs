using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    class Person
    {
        public String name;
        public House house { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"A person with {name} have a house.");
            Console.WriteLine("Data of house: ");
            house.ShowData();
            Console.WriteLine("Data of door: ");
            house.getDoor().ShowData();
           
        }
    }
}
