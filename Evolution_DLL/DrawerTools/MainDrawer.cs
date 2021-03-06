﻿using Evolution_DLL;
using Evolution_DLL.World;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Evolution_DLL.DrawerTools
{
    public class MainDrawer
    {
        private Graphics _graphics;
        private Size _size;
        private GameProcese _gameProcese;

        public MainDrawer (Graphics graphics, int width, int height, GameProcese gameProcese)
        {
            _graphics = graphics;
            _size = new Size(width, height);
            _gameProcese = gameProcese;
        }

        public void Draw()
        {
            SizeError(); 
            DrawField();
            DrawCells(); 
        }

        private void DrawField()
        {
            FieldDrawer.Draw(_graphics, _size, _gameProcese.ThisWorld);
        }

        private void DrawCells()
        {
            CellDrawer.Draw(_graphics, _gameProcese);
        }

        private void SizeError()
        {
            var options = new Specification();
            if (_size.Width < options.CountField * options.SizeCell || _size.Height < options.CountField * options.SizeCell)
            {
                MessageBox.Show("Размеры поля меньше минимально необходимых, пожалуйста увеличте размер окна", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
