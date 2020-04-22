using ObjectLife.World;
using System.Drawing;

namespace Evolution_DLL.World
{
    internal class ThisWorld
    {
        private const int _count = 80;
        private const int _cellSize = 10;

        private Cell[,] _field = new Cell[_count, _count];

        public int Count => _count;
        public int CellSize => _cellSize;

        internal ThisWorld()
        {
            for(var i = 0; i < _count; i++)
            {
                for(var j = 0; j < _count; j++)
                {
                    _field[i, j] = new Cell(new Point(i * 10, j * 10), new Size(_cellSize, _cellSize));
                }
            }
        }
    }
}