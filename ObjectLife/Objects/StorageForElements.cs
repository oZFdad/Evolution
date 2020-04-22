
using System.Collections.Generic;

namespace Evolution_DLL.Objects
{
    internal class StorageForElements
    {
        private List<Element> _elementsList = new List<Element>();
        private int _pointer = 0;

        internal StorageForElements()
        {

        }

        public List<Element> GetElementsList()
        {
            return _elementsList;
        }

        public void AddElements (Element element)
        {
            _elementsList.Add(element);
        }
    }
}
