using Evolution_DLL.Objects;
using System.Drawing;

namespace Evolution_DLL.World
{
    internal class Cell
    {
        private int _x;
        private int _y;
        private Point _point;
        private Size _size;
        private Element _element;

        public Point Point { get => _point; set => _point = value; }
        public Size Size { get => _size; set => _size = value; }
        internal Element Element { get => _element; set => _element = value; }

        public int X => _x;

        public int Y => _y;

        internal Cell(int x, int y)
        {
            var options = new Specification();
            _x = x;
            _y = y;
            _point = new Point(x * options.SizeCell, y * options.SizeCell);
            _size = new Size(options.SizeCell, options.SizeCell);
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
