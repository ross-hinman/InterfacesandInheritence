using System;
namespace InterfacesandInheritance
{
    public class Ashley : Female
    {
        public int Weight { get; set; }
        public string Interests { get; set; }

        public Ashley()
        {
        }

        public void PlayVideogames()
        {
            Console.WriteLine("Ashley's robot is playing video games.");
        }

        public override void Walk()
        {
            base.Walk();
            Console.WriteLine("Ashley's Robot is walking");
        }
    }
}
