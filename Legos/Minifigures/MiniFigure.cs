using Legos.Minifigures.Parts;

namespace Legos.Minifigures
{
    class Minifigure
    {
        readonly Head _head;
        readonly Torso _torso;
        readonly Legs _legs;

        // Head Head { get; } // not setable, so the user can't change to null or something and cause an error

        // Torso Torso { get; }

        public Minifigure(Head head, Torso torso, Legs legs) // instantiates the minifigure and requires the input of a head and torso
        {
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Battle()
        {
            _legs.Walk();
            _head.Talk();
            _torso.Flex();
            _torso.Fight();
            _legs.Kick();
        }
    }
}
