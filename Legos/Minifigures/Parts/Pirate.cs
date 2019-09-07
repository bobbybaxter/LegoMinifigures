using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class PirateTorso : Torso
    {
        public override bool ChestHair => true; // read only property (expression bodied member)

        public PirateTorso(HandType handType)
        {
            HandType = handType;
            Shirt = "Froofy with ruffles";
        }

        public override void Flex()
        {
            Console.WriteLine("The pirate torso flexed swashbucklingly!");
        }

        public override void Fight()
        {
            Console.WriteLine("The pirate torso waves a sword around.");
        }
    }

    enum HandType
    {
        Regular,
        Hook,
        None
    }
}
