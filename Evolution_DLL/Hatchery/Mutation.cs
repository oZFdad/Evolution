using System;
using System.Collections.Generic;
using Evolution_DLL.Genes;
using Evolution_DLL.Objects;

namespace Evolution_DLL.Hatchery
{
    internal class Mutation
    {
        private List<Gene[]> _mutateList = new List<Gene[]>();
        

        public Mutation(List<Organism> mutateList)
        {
            foreach (var organism in mutateList)
            {
                _mutateList.Add((organism.DNA));
            }
        }

        public List<Gene[]> GoEvolution()
        {
            var mutatedList = new List<Gene[]>();
            var rnd = new Random();
            var options = new Specification();
            while (_mutateList.Count!=8)
            {
                var organism = new Organism();
                organism.CreatDNA(rnd);
                _mutateList.Add(organism.DNA);
            }

            foreach (var DNA in _mutateList)
            {
                for (var i = 0; i < 6; i++)
                {
                    mutatedList.Add(DNA);
                }
                for (var i = 0; i < 2; i++)
                {
                    var mutatedDNA = DNA;
                    for (var j = 0; j < 8; j++)
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
                        mutatedDNA[rnd.Next(0, options.DNAcount)] = gene;
                    }
                    mutatedList.Add(mutatedDNA);
                }
            }

            return mutatedList;
        }
    }
}