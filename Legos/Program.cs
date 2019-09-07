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
            //torso.Fight();
            //torso.Flex();

            var minifigure = new Minifigure(head, torso);
            minifigure.Battle();

            //minifigure.Torso = torso;
            //minifigure.Torso.Fight();
        }
    }
}
