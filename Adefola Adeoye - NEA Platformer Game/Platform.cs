﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adefola_Adeoye___NEA_Platformer_Game
{
    public class Platform
    {
        protected int width;
        protected int height;
        protected int Xposition;
        protected int Yposition;
        protected char character;

        public Platform(int h, int w, int x, int y)
        {
            height = h;
            width = w;
            Xposition = x;
            Yposition = y;
            character = '=';
        }

        public void AddPlatform(char[,] map, int Cheight, int Cwidth)
        {
            int rows = map.GetLength(0);
            int cols = map.GetLength(1);
            for (int col = Yposition; col < Yposition + height && (col < cols); col++)
            {
                for (int row = Xposition; row < Xposition + width && (row < rows); row++)
                {
                    if (map[row, col] == ' ')
                    {
                        map[row, col] = character; // Use '=' to represent the platform
                    }

                }
            }
        }

        public int getX()
        {
            return Xposition;
        }

        public int getY()
        {
            return Yposition;
        }

        public char getChar()
        {
            return character;
        }

        public int getWidth()
        {
            return width;
        }
    }
}
