using Evolution_DLL.Objects;
using Evolution_DLL.World;

namespace Evolution_DLL.Actions
{
    internal abstract class ActionAbstract
    {
        internal abstract void Action(Organism organism, ThisWorld thisWorld);
    }
}
