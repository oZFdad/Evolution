
namespace Evolution_DLL
{
    internal class Specification
    {
        private int _amountOfFood = 200; //количество еды
        private int _numberOfOrganism = 16; //количество организмов
        private int _countField = 40; // размер поля
        private int _sizeCell = 15;//размер ячейки
        private int _DNAcount = 64;//длина ДНК
        private int _organismDefaultLife = 100;// базовое значение ХП
        private int _organismMaxLife = 200;// максимальное значение ХП
        private int _lifeFromEat = 50;// значение ХП за пищу
        private int _lifeFromOrganism = 100;//значение ХП за съеденый организм
        private int _delay = 0;// задержка отображения
        private int _gameLimit = 32;// количество иттераций
        private int _lifeForRound = 2;// ротеря ХП зп ход
        private int _lifeForRoundInDefebse = 1;// потеря ХП зп хо в дефенсе
        private int _numOfMutation = 2;//количество мутаций

        public int AmountOfFood { get => _amountOfFood; }
        public int NumberOfOrganism { get => _numberOfOrganism; }
        public int CountField { get => _countField; }
        public int SizeCell { get => _sizeCell; }
        public int DNAcount { get => _DNAcount; }
        public int OrganismDefaultLife { get => _organismDefaultLife; }
        public int LifeFromEat { get => _lifeFromEat; }
        public int LifeFromOrganism { get => _lifeFromOrganism; }
        public int Delay  { get => _delay; }
        public int GameLimit  { get => _gameLimit; }
        public int LifeForRound  { get => _lifeForRound; }
        public int LifeForRoundInDefebse  { get => _lifeForRoundInDefebse; }
        public int OrganismMaxLife  { get => _organismMaxLife; }
        public int NumOfMutation  { get => _numOfMutation; }
    }
}
