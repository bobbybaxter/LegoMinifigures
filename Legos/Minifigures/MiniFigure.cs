using Legos.Minifigures.Parts;

namespace Legos.Minifigures
{
    class Minifigure
    {
        public Head Head { get; set; }

        public Torso Torso { get; set; }

        public Minifigure(Head head, Torso torso) // instantiates the minifigure and requires the input of a head and torso
        {
            Head = head;
            Torso = torso;
        }

        public void Battle()
        {
            Head.Talk();
            Torso.Flex();
            Torso.Fight();
        }
    }
}
