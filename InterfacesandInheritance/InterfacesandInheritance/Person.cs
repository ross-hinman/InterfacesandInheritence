using System;
namespace InterfacesandInheritance
{
    public class Person
    {
        public float Height { get; set; }
        public string Haircut { get; set; }

        public Person()
        {
        }

        public virtual void Walk()
        { 
            Console.WriteLine("Robot is walking");
        }
    }
}
