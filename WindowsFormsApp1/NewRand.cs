using System;
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
            return (xHod, yHod);
        }

        



    }
}
