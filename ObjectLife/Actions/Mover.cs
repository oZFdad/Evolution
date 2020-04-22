
using Evolution_DLL.Objects;
using Evolution_DLL.World;

namespace Evolution_DLL.Actions
{
    class Mover : ActionAbstract
    {
        private int _x;
        private int _y;

        internal Mover(int x, int y)
        {
            _x = x;
            _y = y;
        }

        internal override void Action(Organism organism, ThisWorld thisWorld)
        {
            var element = thisWorld.CheckField(organism.State.Cell, _x, _y);
            if (element == null)
            {
                element = organism;
                organism.State.Cell.Element = null;
                organism.State.Cell = thisWorld.GetCell(organism.State.Cell.Point.X + _x, organism.State.Cell.Point.Y + _y);
            }
        }
    }
}
