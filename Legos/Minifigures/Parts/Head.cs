using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    abstract class Head
    {
        public int NumberOfEyes { get; set; }
        public string EyeColor { get; set; }
        public bool HasNose { get; set; }
        public string HairColor { get; set; }
        public bool MouthIsOpen { get; set; }
        public HeadSize Size { get; protected set; }

        public virtual void Talk() // virtual = we can change any of the base behavior with an override in the inheriting class
        {
            Console.WriteLine("I'm a talking head");
        }

        public abstract void Think(); // any inheriting classes must define a Think() method
        // also, having an abstract method is only possible on an abstract class
    }
}
