

namespace Evolution_DLL
{
    internal class Organism : Element
    {
        private Gene[] _DNA = new Gene[16];

        public Organism()
        {
            _state = new State();
        }
    }   
}
