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
       public PictureBox pct;

        public NewRand(PictureBox pct)
        {
            this.pct = pct;
        }
        public NewRand()
        {
            
        }

        public (int,int) Rerandom()
        {
            int width = pct.Width;
            int height = pct.Height;

            Random rnd = new Random();

            int xHod = rnd.Next(0, width);
            int yHod = rnd.Next(0, height);
            return (xHod, yHod);
        }

        



    }
}
