

using Evolution_DLL.Genes;
using System;

namespace Evolution_DLL
{
    internal class Organism : Element
    {
        private Gene[] _DNA = new Gene[32];
        private bool _defense;
        private bool _scout;

        public Organism()
        {
            _state = new State();
            _defense = false;
            _scout = false;
        }

        internal void CreatDNA()
        {
            var rnd = new Random();
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
    }   
}
