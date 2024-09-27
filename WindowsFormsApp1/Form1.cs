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

        MovePeople movePeople = new MovePeople(buffDataS);
        BotHodit botHodit = new BotHodit();
        public static BuffDatas buffDataS = new BuffDatas();// двумерный массив для хранения информ-ии по заполнению ячеек крестиком или ноликом
        bool gameStarted = false;
        
        private void Form1_Load(object sender, EventArgs e)
        {
           //первичное заполнения ячеек шаблонными данными для проверки подмены в случае хода 
            for (int i=0; i<10; i++)
                for (int j = 0; j<10; j++)
                   buffDataS.buffD[i,j] = "-";

        }

        public void btnClickThis_Click(object sender, EventArgs e) //Разлиновка поля при нажатии кнопки
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
          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

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

                if (radioButton1.Checked == true)
                {
                    movePeople.CentrovkaKrestika(e, ref pctLineXY);
                    botHodit.MoveBot(ref radioButton1,ref pctLineXY);
                    //после выполнения хода изменять значение этой ячейки массива на символ, которым сходили только что
                    //это можно реализовать внутри метода рисования крестика или нолика
                }
                else
                {
                    movePeople.CentrovkaNuLLika(e, ref pctLineXY);
                    botHodit.MoveBot(ref radioButton1,ref pctLineXY);
                }
           
            
        }
       
       
          
        public void radioButton1_CheckedChanged(object sender, EventArgs e) //Крестик
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Нолик
        {

        }
    }
}

    