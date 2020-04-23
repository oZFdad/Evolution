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

        internal override void Action(Organism organism, ThisWorld thisWorld, StorageForElements storageForElements)
        {
            organism.Defense = false;
            if (organism.Scout)
            {
                organism.Scout = false;
                HelpAction(organism, thisWorld, -1, 0, storageForElements);
                HelpAction(organism, thisWorld, 1, 0, storageForElements);
                HelpAction(organism, thisWorld, 0, -1, storageForElements);
                HelpAction(organism, thisWorld, 0, 1, storageForElements);
            }
            else
            {
                HelpAction(organism, thisWorld, _x, _y, storageForElements);
            }
        }

        private void HelpAction(Organism organism, ThisWorld thisWorld, int x, int y, StorageForElements storageForElements)
        {
            var element = thisWorld.CheckField(organism.State.Cell, x, y);
            if (element != null)
            {
                if (element.GetType() == typeof(Eat))
                {
                    organism.State.UpLifeFromEat();
                }
                if(element.GetType()==typeof(Organism))
                {
                    var bufOrganism = (Organism)element;
                    if (bufOrganism.Defense)
                    {
                        return;
                    }
                    organism.State.UpLifeFromOrganism();
                }
                
                element.State.Cell.Element = null;
                storageForElements.DeleteElement(element);
                element = null;
                
            }
        }
    }
}
