
using System.Collections.Generic;

namespace ObjectLife
{
    public class Organism
    {
        private Gene[] _DNA = new Gene[32];
        private State _state;

        public Organism(int x, int y)
        {
            _state = new State(x, y);
        }
    }   
}
