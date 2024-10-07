using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Risovalka
    {
       // public PictureBox pct;
        public MouseEventArgs e;
        //public BuffDatas buffDatas = Form1.buffDataS;

        public Risovalka()
        {
          
        }



        public void Krestik(int x, int y, ref PictureBox pct, ref BuffDatas buffDatas)
        {
            int width = pct.Width;
            int height = pct.Height;
            int stepx = width / 10; //ширина ячейки 
            int stepy = height / 10;// высота ячейки
            int bufX = x / stepx; //количество целых ячеек
            int bufY = y / stepy;

            int coordinataX1 = bufX * stepx;//верхняя левая
            int coordinataY1 = bufY * stepy;

            int coordinataX2 = bufX * stepx + stepx;//верхняя правая
            int coordinataY2 = bufY * stepy;

            int coordinataX3 = bufX * stepx;//верхняя правая
            int coordinataY3 = bufY * stepy + stepy;

            int coordinataX4 = bufX * stepx + stepx;//нижняя правая
            int coordinataY4 = bufY * stepy + stepy;

            Graphics g = pct.CreateGraphics();
            Pen pn = new Pen(Color.Blue, 3);

            g.DrawLine(pn, coordinataX1, coordinataY1, coordinataX4, coordinataY4);
            g.DrawLine(pn, coordinataX3, coordinataY3, coordinataX2, coordinataY2);
            buffDatas.buffD[bufX, bufY] = "X";
            
            //if (buffDatas.buffD[bufX, bufY] == "x" || buffDatas.buffD[bufX, bufY] == "0")
            //{
            //    MessageBox.Show("Выберите другую клетку");
            //}
            //else
            //{
            //    g.DrawLine(pn, coordinataX1, coordinataY1, coordinataX4, coordinataY4);
            //    g.DrawLine(pn, coordinataX3, coordinataY3, coordinataX2, coordinataY2);
            //    buffDatas.buffD[bufX, bufY] = "x";
            //}
        }

        public void Nolik(int x, int y,ref PictureBox pct, ref BuffDatas buffDatas)
        {
            int width = pct.Width;
            int height = pct.Height;
            int stepx = width / 10; //ширина ячейки 
            int stepy = height / 10;// высота ячейки
            //int bufX = x / stepx; //количество целых ячеек
            //int bufY = y / stepy;
            //int coordinataX = bufX * stepx + (stepx / 2);
            //int coordinataY = bufY * stepy + (stepy / 2);
            int coordinataX = x * stepx + (stepx / 2);
            int coordinataY = y * stepy + (stepy / 2);

            Graphics g = pct.CreateGraphics();
            Pen pn = new Pen(Color.Red, 3);
            g.DrawEllipse(pn, coordinataX - 17, coordinataY - 17, 34, 34);
            
            buffDatas.buffD[x, y] = "0";


            //buffDatas.buffD[bufX, bufY] = "0";

            //if (buffDatas.buffD[bufX, bufY] == "x" || buffDatas.buffD[bufX, bufY] == "0")
            //{
            //    MessageBox.Show("Выберите другую клетку");
            //}
            //else
            //{
            //    g.DrawEllipse(pn, coordinataX - 17, coordinataY - 17, 34, 34);
            //    buffDatas.buffD[bufX, bufY] = "0";
            //}
        }
    }
}
