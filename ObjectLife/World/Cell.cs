using Evolution_DLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLife.World
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
    }
}
