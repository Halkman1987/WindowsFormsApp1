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


            Graphics g = pctLineXY.CreateGraphics();
            //Graphics r = pctLineXY.CreateGraphics();
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
                g.DrawEllipse(pn, buffposNull, buffposY1, width, buffposX1);
            }

            //if (m.Button ==  MouseButtons.Left)
            //{
            //    g.DrawEllipse(pn, m.X, m.Y, 20, 20);

            // g.DrawEllipse(pn, buffposX, buffposY1, width, height);
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

        private void pctLineXY_MouseClick(object sender, MouseEventArgs e)
        {


            //var pic = btnClickThis_Click)sender;
            //Graphics g = pctLineXY.CreateGraphics();
            //Pen pn = new Pen(Color.Red, 3);
            //var g = pic.CreateGraphics();
            //if (e.Button == MouseButtons.Left)
            //{

            //    g.DrawEllipse(pn, e.X, e.Y, 20, 20);
            //}
        }

    }
}

    