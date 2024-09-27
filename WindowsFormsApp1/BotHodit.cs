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
       

        public void MoveBot(ref System.Windows.Forms.RadioButton radioButton1, ref PictureBox pctLineXY)
        {
            var rbd = newRand.Rerandom(ref pctLineXY);
            var xHod = rbd.Item1;
            var yHod = rbd.Item2;
            if (radioButton1.Checked == true)
            {
                ris.Nolik(xHod, yHod,ref pctLineXY);
            }
            else
            {
                ris.Krestik(xHod, yHod, ref pctLineXY);
            }
        }
        
    }
}
