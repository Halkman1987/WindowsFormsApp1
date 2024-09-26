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
        NewRand newRand;
        Risovalka ris;


        public void MoveBot()
        {
            var xHod = newRand.Rerandom().Item1;
            var yHod = newRand.Rerandom().Item2;
            if (radioButton1.Checked == true)
            {
                ris.Nolik(xHod, yHod);
            }
            else
            {
                ris.Krestik(xHod, yHod);
            }
        }
        
    }
}
