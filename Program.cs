using System;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a class "House", with an attibute "area", a constructor that sets its value and a method "ShowData" to display "I'm a horse, my area us 200 m2".
            //Include getters and setters for the area, too. ----n-am terminat aici
            //The House will contain a door. Each door will have an attribute "color"(a stirng), and a method "ShowData" wich will display "I'm a door, my color is brown"
            //(or whatever color it really is). Include a getter and a setter. Also, create a "GetDoor" in the house.
            //A "SmallApartment" is subclasses of house, with a present area of 50m2.(Add a validation to prevent entering a value for area greather than 50).
            //Also create a class Person, whith a name String. Which person will have a house.
            //The method "ShowData" for a person will display his/her name, show the data of his /her house and the data of the door of that house.
            //In main(Console.App project), create a small Apartmant, a person to live in it, and to show the data of the person (use interface if you want to add complexity)

            SmallApartment myApartment = new SmallApartment();
            Person myPerson = new Person("Iustin");
            myApartment.door = new House.Door(" red");
            myPerson.house = myApartment;
            myPerson.ShowData();

        }
    }
}
