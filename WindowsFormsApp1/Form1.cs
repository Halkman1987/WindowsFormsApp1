using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnClickThis_Click(object sender, EventArgs e)
        {

            int width = pctLineXY.Width;
            int height = pctLineXY.Height;
            int stepW = width / 10;
            int stepH = height / 10;
            int countW = width / stepW;
            int countH = height / stepH;
            int buffposX = 0;
            int buffposY = 0;
            int buffposX1 = 0;
            int buffposY1 = 0;
            int buffposNull = 0;
           
            var pct = pctLineXY;   //Экземпляр пикчербокса
            pct.MouseClick += pctLineXY_MouseClick; // подписка на клик или что то в этом роде

            Graphics g = pctLineXY.CreateGraphics();
            Pen pn = new Pen(Color.Black, 2);

            for (int i = 0; i <= countW; i++)
            {
                g.DrawLine(pn, buffposX, buffposY, buffposX, height);
                buffposX += stepW;
                
            }
            for (int i = 0; i <= countH; i++)
            {
                g.DrawLine(pn, buffposNull, buffposY1, width, buffposX1);
                buffposY1 += stepH;
                buffposX1 += stepH;
                
            }
       
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void pct_Click(object sender, EventArgs e)
        {

        }

        static public void pctLineXY_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
        public void CentrovkaNuLLika(MouseEventArgs e) //пока не реализован 
        {
            int width = pctLineXY.Width;
            int height = pctLineXY.Height;
            int stepx = width / 10; //ширина ячейки 
            int stepy = height / 10;// высота ячейки
            int bufX = e.X / stepx; //количество целых ячеек
            int bufY = e.Y / stepy;
            int coordinataX = bufX * stepx + (stepx / 2);
            int coordinataY = bufY * stepy + (stepy / 2);
            Graphics g = pctLineXY.CreateGraphics();
            Pen pn = new Pen(Color.Red, 3);
            g.DrawEllipse(pn, coordinataX - 17, coordinataY - 17, 34, 34);
            //return coordinataX;
            //return coordinataY;
        }
        public void CentrovkaKrestika(MouseEventArgs e) //пока не реализован 
        {
            int width = pctLineXY.Width;
            int height = pctLineXY.Height;
            int stepx = width / 10; //ширина ячейки 
            int stepy = height / 10;// высота ячейки
            int bufX = e.X / stepx; //количество целых ячеек
            int bufY = e.Y / stepy;

            int coordinataX1 = bufX * stepx;//верхняя левая
            int coordinataY1 = bufY * stepy;
           
            int coordinataX2 = bufX * stepx + stepx;//верхняя правая
            int coordinataY2 = bufY * stepy;
            
            int coordinataX3 = bufX * stepx;//верхняя правая
            int coordinataY3 = bufY * stepy + stepy;

            int coordinataX4 = bufX * stepx + stepx;//нижняя правая
            int coordinataY4 = bufY * stepy + stepy;


            Graphics g = pctLineXY.CreateGraphics();
            Pen pn = new Pen(Color.Blue, 3);
            g.DrawLine(pn, coordinataX1 , coordinataY1 , coordinataX4, coordinataY4);
            g.DrawLine(pn, coordinataX3, coordinataY3 , coordinataX2, coordinataY2);
            //return coordinataX;
            //return coordinataY;
        }

        private void pctLineXY_MouseClick(object sender, MouseEventArgs e) // событие клика левой клавишей по пикчербоксу
        {

           
            if (e.Button == MouseButtons.Right)
            {
                CentrovkaKrestika(e);
                //int width = pctLineXY.Width;
                //int height = pctLineXY.Height;
                //int stepx = width / 10; //ширина ячейки 
                //int stepy = height / 10;// высота ячейки
                //int bufX = e.X / stepx; //количество целых ячеек
                //int bufY = e.Y / stepy;
                //int coordinataX = bufX * stepx + (stepx / 2);
                //int coordinataY = bufY * stepy + (stepy / 2);
               
                //Graphics g = pctLineXY.CreateGraphics();
                //Pen pn = new Pen(Color.Green, 2);
                //g.DrawEllipse(pn, coordinataX-10, coordinataY-10, 20, 20);
            }
            
            if (e.Button == MouseButtons.Left)
            {
                CentrovkaNuLLika(e);
               // CentrovkaKrestik(e);
                //Graphics g = pctLineXY.CreateGraphics();
                //Pen pn = new Pen(Color.Red, 2);
                //g.DrawEllipse(pn, e.X-15, e.Y-15, 30, 30);

            }
        }
    }
}

    