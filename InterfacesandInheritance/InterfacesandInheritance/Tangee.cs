using System;
namespace InterfacesandInheritance
{
    public class Tangee : Female
    {
        public string SkinColor { get; set; }
        public bool HasGlasses { get; set; }

        public Tangee()
        {
        }

        public void LaughDifferently()
        {
            Console.WriteLine("Tangee's robot laughs differently");
        }
    }
}
