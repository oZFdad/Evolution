using Evolution_DLL.Objects;
using ObjectLife.World;
using System;
using System.Drawing;

namespace Evolution_DLL.World
{
    public class GameProcese
    {
        private StorageForElements _storageElements;
        private ThisWorld _thisWorld;

        internal ThisWorld ThisWorld { get => _thisWorld; }
        internal StorageForElements StorageElements { get => _storageElements; }

        public GameProcese()
        {
            _storageElements = new StorageForElements();
            _thisWorld = new ThisWorld();
        }

        public void GameStart()
        {
            FillLife();
            CreatDNA();
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
            foreach(var element in _storageElements.GetElementsList())
            {
                if (element.GetType() == typeof(Organism))
                {
                    Organism organism = (Organism)element;
                    organism.CreatDNA();
                }
            }
        }
    }
}
