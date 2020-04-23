using Evolution_DLL.Genes;
using System;
using System.Threading;

namespace Evolution_DLL.Objects
{
    internal class Organism : Element
    {
        private Gene[] _DNA;
        private bool _defense;
        private bool _scout;

        public Organism()
        {
            var options = new Specification();
            _DNA = new Gene[options.DNAcount];
            _state = new State();
            _defense = false;
            _scout = false;
        }

        public bool Defense { get => _defense; set => _defense = value; }
        public bool Scout { get => _scout; set => _scout = value; }

        internal void CreatDNA(Random rnd)
        {
            for(var i = 0; i < _DNA.Length; i++)
            {
                Gene gene;
                switch(rnd.Next(1, 11))
                {
                    case 1:
                        gene = new AttackDawn();
                        break;
                    case 2:
                        gene = new AttackLeft();
                        break;
                    case 3:
                        gene = new AttackRight();
                        break;
                    case 4:
                        gene = new AttackUp();
                        break;
                    case 5:
                        gene = new Defense();
                        break;
                    case 6:
                        gene = new GoDawn();
                        break;
                    case 7:
                        gene = new GoLeft();
                        break;
                    case 8:
                        gene = new GoRight();
                        break;
                    case 9:
                        gene = new GoUp();
                        break;
                    case 10:
                        gene = new Scout();
                        break;
                    default:
                        gene = new Scout();
                        break;
                }
                _DNA[i] = gene;
            }
        }

        internal Gene GetGene (int num)
        {
            return _DNA[num];
        }

        public bool IsLife()
        {
            Scout = false;
            var options = new Specification();
            if (Defense)
            {
                _defense = false;
                State.Life -= options.LifeForRoundInDefebse;
            }
            else
            {
                State.Life -= options.LifeForRound;
            }

            return State.Life >= 1;
        }
    }   
}
