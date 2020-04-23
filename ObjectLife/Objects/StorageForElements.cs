using System.Collections.Generic;

namespace Evolution_DLL.Objects
{
    internal class StorageForElements
    {
        private List<Element> _elementsList = new List<Element>();

        internal List<Element> GetElementsList()
        {
            return _elementsList;
        }

        internal void AddElements (Element element)
        {
            _elementsList.Add(element);
        }

        internal List<Organism> GetOrganismsList()
        {
            var organismsList = new List<Organism>();
            foreach (var element in _elementsList)
            {
                if (element.GetType() == typeof(Organism))
                {
                    var organism = (Organism)element;
                    organismsList.Add(organism);
                }
            }
            return organismsList;
        }

        internal void DeleteElement(Element element)
        {
            _elementsList.Remove(element);
        }

        public List<Eat> GetEatList()
        {
            var eatsList = new List<Eat>();
            foreach (var element in _elementsList)
            {
                if (element.GetType() == typeof(Eat))
                {
                    var eat = (Eat)element;
                    eatsList.Add(eat);
                }
            }
            return eatsList;
        }
    }
}
