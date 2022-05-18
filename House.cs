using System;

namespace Tema2
{
    class House
    {
        public int Area { get; set; }
        public Door door;

        public House(int area = 200)
        {
            Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a horse, my area is {Area} m2");
        }
        public Door getDoor()
        {
            return door;
        }
    }
}
