

namespace Evolution_DLL
{
    internal abstract class Element
    {
        protected State _state;

        internal State State { get => _state; set => _state = value; }
    }
}