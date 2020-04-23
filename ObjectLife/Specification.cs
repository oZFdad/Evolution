
namespace Evolution_DLL
{
    internal class Specification
    {
        private int _amountOfFood = 0; //200 default
        private int _numberOfOrganism = 16; //64 default
        private int _countField = 20; // 80 default
        private int _sizeCell = 10;
        private int _DNAcount = 64;
        private int _organismLife = 100;
        private int _lifeFromEat = 100;
        private int _lifeFromOrganism = 200;
        private int _delay = 0;
        private int _gameLimit = 64;
        private int _lifeForRound = 2;
        private int _lifeForRoundInDefebse = 1;

        public int AmountOfFood { get => _amountOfFood; }
        public int NumberOfOrganism { get => _numberOfOrganism; }
        public int CountField { get => _countField; }
        public int SizeCell { get => _sizeCell; }
        public int DNAcount { get => _DNAcount; }
        public int OrganismLife { get => _organismLife; }
        public int LifeFromEat { get => _lifeFromEat; }
        public int LifeFromOrganism { get => _lifeFromOrganism; }
        public int Delay  { get => _delay; }
        public int GameLimit  { get => _gameLimit; }
        public int LifeForRound  { get => _lifeForRound; }
        public int LifeForRoundInDefebse  { get => _lifeForRoundInDefebse; }
    }
}
