using ObjectLife.World;

namespace Evolution_DLL
{
    internal class State
    {
        private int _life;
        private Cell _cell;
        
        public int Life { get => _life; set => _life = value; }
        internal Cell Cell { get => _cell; set => _cell = value; }

        public State()
        {
            Life = 100;
            Cell = null;
        }
    }
}