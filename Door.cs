using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    class Door : House
    {
        public String Color { get; set; }

        public Door(string color = "brown") : base(color) => Color = color;
        public void ShowData()
        {
            Console.WriteLine($"I'm a door, my color is{Color}");
        }
    }
}
