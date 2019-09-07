using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YodaHead : Head
    {
        public bool HasEars { get; private set; }

        public YodaHead()
        {
            Size = HeadSize.Small;
            HasEars = true;
        }

        public override void Talk() // changes the default behavior of a virtual class
        {
            Console.WriteLine("Talking head I am");
        }

        public void Battle()
        {
            HasEars = false;
        }

        public override void Think() // changes/defines the default behavior of the abstract method
        {
            Console.WriteLine("Thinking I am");
        }
    }
}
