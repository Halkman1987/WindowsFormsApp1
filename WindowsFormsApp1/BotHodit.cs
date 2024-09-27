using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    internal class BotHodit
    {
        NewRand newRand = new NewRand();
        Risovalka ris = new Risovalka();
        public bool chk = false;

        public void MoveBotNolik(/*ref System.Windows.Forms.RadioButton radioButton1,*/ ref PictureBox pctLineXY,ref BuffDatas buffDatas)
        {
            var rbd = newRand.Rerandom(ref pctLineXY);
            var xHod = rbd.Item1;
            var yHod = rbd.Item2;
            int bufX;
            int bufY;
           // CheckBox(xHod, yHod, ref buffDatas);

            if (chk == false)
            {
                do
                {
                    var rnd = newRand.Rerandom(ref pctLineXY);
                    bufX = rnd.Item1;
                    bufY = rnd.Item2;

                    CheckBox(bufX, bufY, ref buffDatas);
                }
                while (chk == false);

                
                ris.Nolik(bufX, bufY, ref pctLineXY, ref buffDatas);
               
            }
            else 
            {
                ris.Nolik(xHod, yHod, ref pctLineXY, ref buffDatas);
                //do
                //{
                //    var rnd = newRand.Rerandom(ref pctLineXY);
                //    var bufX = rnd.Item1;
                //    var bufY = rnd.Item2;

                //    CheckBox(bufX, bufY,ref buffDatas);
                //}
                //while (chk == false);

                //while (chk == false)
                //{
                //    var rnd = newRand.Rerandom(ref pctLineXY);
                //    var bufX = rnd.Item1;
                //    var bufY = rnd.Item2;

                //    CheckBox(bufX, bufY,ref buffDatas);

                //}

            }
           /* if (radioButton1.Checked == true)
            {
                var rbd = newRand.Rerandom(ref pctLineXY);
                var xHod = rbd.Item1;
                var yHod = rbd.Item2;
                CheckBox(xHod, yHod, ref pctLineXY);
                //ris.Nolik(xHod, yHod, ref pctLineXY);
                if (chk == true)
                {
                    ris.Nolik(xHod, yHod, ref pctLineXY);
                }
                else
                {
                    while (chk == false)
                    {
                        var rnd = newRand.Rerandom(ref pctLineXY);
                        var bufX = rnd.Item1;
                        var bufY = rnd.Item2;
                        //var NewxHod = rnd.Item1;
                        //var NewyHod = rnd.Item2;
                        //int width = pctLineXY.Width;
                        //int height = pctLineXY.Height;
                        //int stepx = width / 10; //ширина ячейки 
                        //int stepy = height / 10;// высота ячейки
                        //int bufX = NewxHod / stepx; //количество целых ячеек
                        //int bufY = NewyHod / stepy;
                        CheckBox(bufX, bufY, ref pctLineXY);

                    }
                    ris.Nolik(xHod, yHod, ref pctLineXY);
                }
                
            }
            else
            {
               // ris.Krestik(xHod, yHod, ref pctLineXY);
            }*/
        }
        public bool CheckBox(int x, int y , ref BuffDatas buffDatas)
        {
          
         if (buffDatas.buffD[x,y] == "X" || buffDatas.buffD[x,y] == "0")
            {
                chk = false;
            }
            else
            {
                chk = true;
            }
              return chk;
        }
        
    }
}
