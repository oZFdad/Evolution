using Evolution_DLL.Objects;
using System.Drawing;

namespace Evolution_DLL.World
{
    internal class Cell
    {
        private Point _point;
        private Size _size;
        private Element _element;

        public Point Point { get => _point; set => _point = value; }
        public Size Size { get => _size; set => _size = value; }
        internal Element Element { get => _element; set => _element = value; }

        internal Cell(Point point, Size size)
        {
            _point = point;
            _size = size;
            _element = null;
        }

        internal Rectangle GetRectangle()
        {
            return new Rectangle(_point, _size);
        }

        internal void Checkneighbour()
        {

        }
    }
}
