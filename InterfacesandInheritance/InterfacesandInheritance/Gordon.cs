using System;
namespace InterfacesandInheritance
{
    public class Gordon : Person
    {
        public bool HasFacialHair { get; set; }
        public int Weight { get; set; }

        public Gordon()
        {
        }

        public void MixMusic()
        {
            Console.WriteLine("Gordon's robot is mixing music");
        }
    }
}
