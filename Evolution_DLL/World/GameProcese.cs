﻿using Evolution_DLL.Actions;
using Evolution_DLL.Objects;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Threading;
using Evolution_DLL.Hatchery;

namespace Evolution_DLL.World
{
    public class GameProcese
    {
        private ThisWorld _thisWorld;
        private int _round;
        private int _generation = 0;
        private List<Gene[]> _mutateDNAList = new List<Gene[]>();

        public delegate void EventHandler();
        public event EventHandler EventChange;
        public event EventHandler EndRound;


        internal ThisWorld ThisWorld { get => _thisWorld; }
        public int Generation { get => _generation; }
        public int Round { get => _round; }

        public GameProcese()
        {
            _thisWorld = new ThisWorld();
            _round = 0;
        }

        public void GameStart()
        {
            AllClear();
            _generation++;
            FillLife();
            CreatDNA();
            GoAction();
            GoMutation();
            EndRound?.Invoke();
        }

        private void AllClear()
        {
            _thisWorld = new ThisWorld();
            _round = 0;
        }

        public void NextIteration()
        {
            //GoAction();
            //GoMutation();
        }

        private void FillLife()
        {
            var options = new Specification();
            var rnd = new Random();
            for(var i = 0; i < options.AmountOfFood; i++)
            {
                var x = rnd.Next(0, options.CountField);
                var y = rnd.Next(0, options.CountField);
                if(_thisWorld.CheckFreeSpace(x, y))
                {
                    var eat = new Eat();
                    _thisWorld.GetCell(x, y).Element = eat;
                    eat.State.Cell = _thisWorld.GetCell(x, y);
                    _thisWorld.StorageElements.AddElements(eat);
                    EventChange?.Invoke();
                }
                else
                {
                    i--;
                }
            }
            for (var i = 0; i < options.NumberOfOrganism; i++)
            {
                var x = rnd.Next(0, options.CountField);
                var y = rnd.Next(0, options.CountField);
                if (_thisWorld.CheckFreeSpace(x, y))
                {
                    var organism = new Organism();
                    _thisWorld.GetCell(x, y).Element = organism;
                    organism.State.Cell = _thisWorld.GetCell(x, y);
                    _thisWorld.StorageElements.AddElements(organism);
                    EventChange?.Invoke();
                }
                else
                {
                    i--;
                }
            }
        }

        private void CreatDNA()
        {
            if (_mutateDNAList.Count == 0)
            {
                var rnd = new Random();
                foreach (var organism in _thisWorld.StorageElements.GetOrganismsList())
                {
                    organism.CreatDNA(rnd);
                }
            }
            else
            {
                for(var i = 0; i < _mutateDNAList.Count; i++)
                {
                    _thisWorld.StorageElements.GetOrganismsList()[i].DNA = _mutateDNAList[i];
                }
            }
        }

        private void GoAction()
        {
            var options = new Specification();
            //while (_round < options.GameLimit)
            while (_thisWorld.StorageElements.GetOrganismsList().Count > 8)
            {
                var pointer = Round % options.DNAcount;
                foreach (var organism in _thisWorld.StorageElements.GetOrganismsList())
                {
                    if (!organism.IsLife())
                    {
                        _thisWorld.DeleteElement(organism);
                    }
                    else
                    {
                        var action = Separater.GetAction(organism.GetGene(pointer));
                        action.Action(organism, _thisWorld, _thisWorld.StorageElements);
                    }
                    EventChange?.Invoke();
                    Thread.Sleep(options.Delay);
                }
                _round++;
                Application.DoEvents();
            }
        }

        private void GoMutation()
        {
            var mutation = new Mutation(_thisWorld.StorageElements.GetOrganismsList());
            _mutateDNAList = mutation.GoEvolution();
        }

        public string GetInfoForSave()
        {
            var s3 = Convert.ToString(Generation);
            return "\nитерация - " + Convert.ToString(Round) + "\nпоколение - " + Convert.ToString(Generation);
        }

        public string GerInfo()
        {
            var s1 = Convert.ToString(_thisWorld.StorageElements.GetOrganismsList().Count);
            var s2 = Convert.ToString(_thisWorld.StorageElements.GetEatList().Count);
            var s3 = Convert.ToString(Generation);
            return "Живых организмов - " + s1 + "\nЕды - " + s2 + "\nитерация - " + Convert.ToString(Round) + "\nпоколение - " + Convert.ToString(Generation);
        }

        public List<int> GetFullCells() // мусор
        {
            return _thisWorld.Free();
        }
    }
}
