using Evolution_DLL.World;

namespace Evolution_DLL.Objects
{
    internal class State
    {
        private int _life;
        private Cell _cell;
        
        public int Life { get => _life; set => _life = value; }
        internal Cell Cell { get => _cell; set => _cell = value; }

        public State()
        {
            var options = new Specification();
            Life = options.OrganismDefaultLife;
            Cell = null;
        }

        internal void UpLifeFromEat()
        {
            var options = new Specification();
            _life += options.LifeFromEat;
            if (_life > options.OrganismMaxLife)
            {
                _life = options.OrganismMaxLife;
            }
        }

        internal void UpLifeFromOrganism()
        {
            var options = new Specification();
            _life += options.LifeFromOrganism;
            if (_life > options.OrganismMaxLife)
            {
                _life = options.OrganismMaxLife;
            }
        }
    }
}