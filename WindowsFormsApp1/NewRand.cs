﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class NewRand
    {
        
        public (int,int) Rerandom(ref PictureBox pctLineXY)
        {
            int width = pctLineXY.Width;
            int height = pctLineXY.Height;

            Random rnd = new Random();

            int xHod = rnd.Next(0, width);
            int yHod = rnd.Next(0, height);

            //var NewxHod = rnd.Item1;
            //var NewyHod = rnd.Item2;
           
            int stepx = width / 10; //ширина ячейки 
            int stepy = height / 10;// высота ячейки
            int bufX = xHod / stepx; //количество целых ячеек
            int bufY = yHod / stepy;

            return (bufX, bufY);
        }

        



    }
}
