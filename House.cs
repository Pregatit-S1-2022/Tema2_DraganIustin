using System;

namespace Tema2
{
    class House
    {
        private string color;

        public int Area { get; set; }
        public Door door { get; set; }

        public House(int area = 200)
        {
            Area = area;
        }

        public House(string color)
        {
            this.color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a house, my area is {Area} m2");
        }
        public Door getDoor()
        {
            return door;
        }

        internal class Door : Tema2.Door
        {
            public Door(string color = "brown") : base(color)
            {
            }
        }
    }
}
