using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    abstract class Torso
    {
        public abstract bool ChestHair { get; }
        public HandType HandType { get; set; }
        public int NumberOfArms { get; set; }
        public string Shirt { get; set; }

        public abstract void Flex();
        public abstract void Fight();
    }
}
