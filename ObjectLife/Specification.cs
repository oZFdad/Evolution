
namespace Evolution_DLL
{
    internal class Specification
    {
        private int _amountOfFood = 200;
        private int _numberOfOrganism = 64;
        private int _countField = 80;
        private int _sizeCell = 10;
        private int _DNAcount = 32;
        private int _organismLife = 100;
        private int _lifeFromEat = 100;
        private int _lifeFromOrganism = 200;

        public int AmountOfFood { get => _amountOfFood; }
        public int NumberOfOrganism { get => _numberOfOrganism; }
        public int CountField { get => _countField; }
        public int SizeCell { get => _sizeCell; }
        public int DNAcount { get => _DNAcount; }
        public int OrganismLife { get => _organismLife; }
        public int LifeFromEat { get => _lifeFromEat; }
        public int LifeFromOrganism { get => _lifeFromOrganism; }
    }
}
