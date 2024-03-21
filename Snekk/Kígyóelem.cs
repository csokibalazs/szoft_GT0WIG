using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snekk
{
    internal class Kígyóelem : PictureBox
    {
        public static int Méret = 20;
        public int Hossz = 1;

        public Kígyóelem()
        {
            Width = Kígyóelem.Méret;
            Height = Kígyóelem.Méret;
            BackColor = Color.Blue;
        }
    }
}
