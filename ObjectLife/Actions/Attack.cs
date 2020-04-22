using Evolution_DLL.Objects;
using Evolution_DLL.World;

namespace Evolution_DLL.Actions
{
    class Attack : ActionAbstract
    {
        private int _x;
        private int _y;

        internal Attack(int x, int y)
        {
            _x = x;
            _y = y;
        }

        internal override void Action(Organism organism, ThisWorld thisWorld)
        {
            if (organism.Scout)
            {
                organism.Scout = false;
                HelpAction(organism, thisWorld, -1, 0);
                HelpAction(organism, thisWorld, 1, 0);
                HelpAction(organism, thisWorld, 0, -1);
                HelpAction(organism, thisWorld, 0, 1);
            }
            else
            {
                HelpAction(organism, thisWorld, _x, _y);
            }
        }

        private void HelpAction(Organism organism, ThisWorld thisWorld, int x, int y)
        {
            var element = thisWorld.CheckField(organism.State.Cell, x, y);
            if (element != null)
            {
                if (element.GetType() == typeof(Eat))
                {
                    organism.State.UpLifeFromEat();
                }
                else
                {
                    organism.State.UpLifeFromOrganism();
                }
                element = null;
            }
        }
    }
}
