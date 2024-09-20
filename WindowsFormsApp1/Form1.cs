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
        
        string[,] buffDatas = new string[10, 10]; // двумерный массив для хранения информ-ии по заполнению ячеек крестиком или ноликом
        
        bool gameStarted = false;
        private void Form1_Load(object sender, EventArgs e)
        {
           //первичное заполнения ячеек шаблонными данными для проверки подмены в случае хода 
            for (int i=0; i<10; i++)
                for (int j = 0; j<10; j++)
                    buffDatas[i,j] = "-";

        }

        public void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = " Разметка завершенна !";
            lblHelloWorld.ForeColor = System.Drawing.Color.BlueViolet;
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

            for (int i = 0; i <= countW; i++) //разлиновка поля
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

        static public void pctLineXY_Click(object sender, EventArgs e )
        {
           
          //  int width = pctLineXY.Width;
          //  int height = pctLineXY.Height;
          //  int stepW = width / 10;
          //  int stepH = height / 10;
          //  int countW = width / stepW;
          //  int countH = height / stepH;
          //  int buffposX = 0;
          //  int buffposY = 0;
          //  int buffposX1 = 0;
          //  int buffposY1 = 0;
          //  int buffposNull = 0;

          // // var pct = pctLineXY;   //Экземпляр пикчербокса
          ////  pct.MouseClick += pctLineXY_MouseClick; // подписка на клик или что то в этом роде

          //  Graphics g = pctLineXY.CreateGraphics();
          //  Pen pn = new Pen(Color.Black, 2);

          //  for (int i = 0; i <= countW; i++)
          //  {
          //      g.DrawLine(pn, buffposX, buffposY, buffposX, height);
          //      buffposX += stepW;

          //  }
          //  for (int i = 0; i <= countH; i++)
          //  {
          //      g.DrawLine(pn, buffposNull, buffposY1, width, buffposX1);
          //      buffposY1 += stepH;
          //      buffposX1 += stepH;

          //  }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
       
        public void ChertaGorizonta() // Метод для определения победы (НЕ НАПИСАН)
        {

        }
        public void CentrovkaNuLLika(MouseEventArgs e) // Метод для Нолика
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
            if (buffDatas[bufX, bufY] == "x" || buffDatas[bufX, bufY] == "0")
            {
                MessageBox.Show("Выберите другую клетку");
                //g.DrawEllipse(pn, coordinataX - 17, coordinataY - 17, 34, 34);
                //buffDatas[bufX, bufY] = "0";
            }
            else
            {
                g.DrawEllipse(pn, coordinataX - 17, coordinataY - 17, 34, 34);
                buffDatas[bufX, bufY] = "0";
            }    
            

        }
        public void CentrovkaKrestika(MouseEventArgs e) // Метод для крестика
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
            if (buffDatas[bufX, bufY] == "x" || buffDatas[bufX, bufY] == "0")
            {
                MessageBox.Show("Выберите другую клетку"); 
            }
            else
            {
                g.DrawLine(pn, coordinataX1, coordinataY1, coordinataX4, coordinataY4);
                g.DrawLine(pn, coordinataX3, coordinataY3, coordinataX2, coordinataY2);
                buffDatas[bufX, bufY] = "x";
            }

        }
        

        private void pctLineXY_MouseClick(object sender, MouseEventArgs e) // событие клика левой клавишей по пикчербоксу
        {
            if(gameStarted == false)
            {
                gameStarted = true;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }

            int x = e.X / (pctLineXY.Width / 10);
            int y = e.Y / (pctLineXY.Height / 10);

           // if (buffDatas[x,y] == "-")
                if (radioButton1.Checked == true)
                {
                    CentrovkaKrestika(e);
                    botHodit();
                    
                    //после выполнения хода изменять значение этой ячейки массива на символ, которым сходили только что
                    //это можно реализовать внутри метода рисования крестика или нолика
                }
                else
                {
                   
                    CentrovkaNuLLika(e);
                    botHodit();
                }
            //else
            //{
            //   // botHodit();
            //}
            
        }
        public void botHodit() //ход бота
        {
           
            int width = pctLineXY.Width;
            int height = pctLineXY.Height;

            Random rnd = new Random();

            int xHod = rnd.Next(0, width);
            int yHod = rnd.Next(0, height);
           
            int stepx = width / 10; //ширина ячейки 
            int stepy = height / 10;// высота ячейки
            int hx = xHod/stepx;
            int hy = yHod/stepy;

            //if (buffDatas[hx, hy] == "-")
            //{
            //    botNuLLik(xHod, yHod);
            //}

            if (radioButton1.Checked == true)
            {
                botNuLLik(xHod, yHod);
            }
            else
            {
                botKrestik(xHod, yHod);
            }

            // = buffDatas[x,y];
            //рандомно (пока что) выбрать из массива buffDatas свободную ячейку и сходить туда противоположным игроку символом (крестик или нолик)
            //придется изменить вызов методов рисования крестика и нолика, т.к. там на вход подается mouseevent
            //из этого метода ты должен вызвать метод рисования крестика или нолика, передавать на вход координаты нужные и значение символа
            //(чем рисовать - крестиком или ноликом)

        }
        public void botNuLLik(int x,int y) // Метод для Нолика
        {
            int width = pctLineXY.Width;
            int height = pctLineXY.Height;
            int stepx = width / 10; //ширина ячейки 
            int stepy = height / 10;// высота ячейки
            int bufX = x / stepx; //количество целых ячеек
            int bufY = y / stepy;
            int coordinataX = bufX * stepx + (stepx / 2);
            int coordinataY = bufY * stepy + (stepy / 2);
            Graphics g = pctLineXY.CreateGraphics();
            Pen pn = new Pen(Color.Brown, 3);
            if (buffDatas[bufX, bufY] == "-")
            {
                g.DrawEllipse(pn, coordinataX - 17, coordinataY - 17, 34, 34);
                buffDatas[bufX, bufY] = "0";
            }
                
        }
        public void botKrestik(int x, int y)
        {
            int width = pctLineXY.Width;
            int height = pctLineXY.Height;
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

            Graphics g = pctLineXY.CreateGraphics();
            Pen pn = new Pen(Color.Blue, 3);
            if (buffDatas[bufX, bufY] == "x" || buffDatas[bufX, bufY] == "0")
            {
                MessageBox.Show("Выберите другую клетку");
            }
            else
            {
                g.DrawLine(pn, coordinataX1, coordinataY1, coordinataX4, coordinataY4);
                g.DrawLine(pn, coordinataX3, coordinataY3, coordinataX2, coordinataY2);
                buffDatas[bufX, bufY] = "x";
            }
               
        }
          
        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Крестик
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Нолик
        {

        }
    }
}

    