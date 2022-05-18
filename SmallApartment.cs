using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    class SmallApartment: House
    {
        public SmallApartment(int area = 50) : base(area)
        {
            Console.WriteLine("Pleas, enter a area: ");
            
            int newArea = Int32.Parse(Console.ReadLine());
            if(newArea > 50)
            {
                Console.WriteLine($"Your area is: {newArea} m2 and is greater than {area}. Your area will set automatically to {area}");
                newArea = area;
            }
        }
    }
}
