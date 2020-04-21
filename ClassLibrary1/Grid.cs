﻿
using System.Drawing;

namespace PainBox_DLL
{
    public class Grid
    {
        private int _x;
        private int _y;

        public Grid(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static void PainGrid (Graphics graphics, int width, int height)
        {
            var pen = new Pen(Color.Black);

            for (var i = 0; i <= width; i += 10)
            {
                graphics.DrawLine(pen, i, 0, i, height);
            }

            for (var i = 0; i <= height; i += 10)
            {
                graphics.DrawLine(pen, 0, i, width, i);
            }
        }
    }
}