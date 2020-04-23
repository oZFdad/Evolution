using System.Collections.Generic;
using Evolution_DLL.Objects;
using Evolution_DLL.World;
using System.Drawing;

namespace Evolution_DLL.World
{
    internal class ThisWorld
    {
        private Cell[,] _field;
        
        internal ThisWorld()
        {
            var options = new Specification();
            _field = new Cell[options.CountField, options.CountField];
            for (var i = 0; i < options.CountField; i++)
            {
                for(var j = 0; j < options.CountField; j++)
                {
                    _field[i, j] = new Cell(new Point(i * 10, j * 10), new Size(options.SizeCell, options.SizeCell));
                }
            }
        }

        internal bool CheckFreeSpace(int x, int y)
        {
            if (_field[x, y].Element == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal Cell GetCell (int x, int y)
        {
            var options = new Specification();
            if (x == -1)
            {
                x = options.CountField - 1;
            }

            if (x == options.CountField)
            {
                x = 0;
            }
            
            if (y == -1)
            {
                y = options.CountField - 1;
            }

            if (y == options.CountField)
            {
                y = 0;
            }
            
            return _field[x, y];
        }

        internal Element CheckField (Cell cell, int x, int y)
        {
            var options = new Specification();
            x = cell.Point.X / 10 + x;
            y = cell.Point.Y / 10 + y;
            
            if (x == -1)
            {
                x = options.CountField - 1;
            }

            if (x == options.CountField)
            {
                x = 0;
            }
            
            if (y == -1)
            {
                y = options.CountField - 1;
            }

            if (y == options.CountField)
            {
                y = 0;
            }

            return _field[x, y].Element;
        }

        internal List<int> Free()
        {
            var list = new List<int>();
            var options = new Specification();
            for (var i = 0; i < options.CountField; i++)
            {
                for (var j = 0; j < options.CountField; j++)
                {
                    if (!CheckFreeSpace(i, j))
                    {
                        list.Add(i);
                        list.Add(j);
                    }
                }
            }

            return list;
        }
    }
}