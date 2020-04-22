using Evolution_DLL.Objects;
using Evolution_DLL.World;

namespace Evolution_DLL.Actions
{
    class Scouter : ActionAbstract
    {
        internal override void Action(Organism organism, ThisWorld thisWorld)
        {
            organism.Scout = true;
        }
    }
}
