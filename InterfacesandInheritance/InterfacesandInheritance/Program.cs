using System;

namespace InterfacesandInheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var robotG = new Gordon()
            {
                Height = 6.2f,
                Weight = 160,
                HasFacialHair = false,
                Haircut = "short sides"
            };
            robotG.Walk();
            robotG.MixMusic();
            var robotA = new Ashley()
            {
                Height = 5.4f,
                Weight = 120,
                HairColor = "Black",
                Haircut = "Short",
                Interests = "Playing video games"
            };
            robotA.PlayVideogames();
            robotA.Walk();
            var robotT = new Tangee()
            {
                HairColor = "Black",
                Haircut = "Curley",
                SkinColor = "Black",
                Height = 5.6f,
                HasGlasses = true
            };
            robotT.LaughDifferently();
            robotT.Walk();

        }
    }
}
