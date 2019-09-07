using System;
using Legos.Minifigures;
using Legos.Minifigures.Parts;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 3,
            };

            //var minifigure = new Minifigure();
            //minifigure.Head = new YodaHead
            //{
            //    EyeColor = "Brown",
            //    HairColor = "Blue",
            //    HasNose = false,
            //    MouthIsOpen = true,
            //    NumberOfEyes = 3,
            //};

            //var fatHead = new FatHead();

            //fatHead.Talk();
            //minifigure.Head.Talk();

            //switch (minifigure.Head)
            //{
            //    case YodaHead h:
            //        h.Battle();
            //        break;
            //}

            var torso = new YetiTorso();
            var legs = new ZombieLegs();
            //torso.Fight();
            //torso.Flex();

            var yodaYetiZombie = new Minifigure(head, torso, legs);
            yodaYetiZombie.Battle();

            //minifigure.Torso = torso;
            //minifigure.Torso.Fight();

            var fatHead = new FatHead();
            var pirateTorso = new PirateTorso(HandType.Hook);
            var centaurLegs = new CentaurLegs();

            var fatHeadedCentaurPirate = new Minifigure(fatHead, pirateTorso, centaurLegs);
            fatHeadedCentaurPirate.Battle();
        }
    }
}
