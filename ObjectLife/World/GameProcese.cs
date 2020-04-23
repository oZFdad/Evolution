﻿using Evolution_DLL.Actions;
using Evolution_DLL.Objects;
using System.Windows.Forms;
using System;
using System.Threading;

namespace Evolution_DLL.World
{
    public class GameProcese
    {
        private StorageForElements _storageElements;
        private ThisWorld _thisWorld;
        private int _round;

        internal ThisWorld ThisWorld { get => _thisWorld; }
        internal StorageForElements StorageElements { get => _storageElements; }

        public GameProcese()
        {
            _storageElements = new StorageForElements();
            _thisWorld = new ThisWorld();
            _round = 0;
        }

        public void GameStart()
        {
            FillLife();
            CreatDNA();
        }

        public void NextIteration()
        {
            GoAction();
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
                    _storageElements.AddElements(eat);
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
                    _storageElements.AddElements(organism);
                }
                else
                {
                    i--;
                }
            }
        }

        private void CreatDNA()
        {
            foreach(var organism in _storageElements.GetOrganismsList())
            {
                organism.CreatDNA();
            }
        }

        private void GoAction()
        {
            var options = new Specification();
            var pointer = _round % options.DNAcount;
            foreach (var organism in _storageElements.GetOrganismsList())
            {
                var action = Separater.GetAction(organism.GetGene(pointer));
                action.Action(organism, _thisWorld);
            }
            Update();
            Thread.Sleep(500);
            _round++;
        }

        private void Update()
        {
        }
    }
}
