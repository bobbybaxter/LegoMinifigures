using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YetiTorso : Torso
    {
        public override bool ChestHair => true;

        public YetiTorso()
        {
            HandType = HandType.None;
            Shirt = "none";
            NumberOfArms = 2;
        }

        public override void Flex()
        {
            Console.WriteLine("The Yeti torso flexes menacingly with no hands");
        }

        public override void Fight()
        {
            Console.WriteLine("The Yeti torso smacks you with his nubs...");
        }
    }
}
