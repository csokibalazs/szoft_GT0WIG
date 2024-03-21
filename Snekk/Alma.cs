using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snekk
{
    internal class Alma : PictureBox
    {
        public static int Méret = 20;
        public Alma()
        {
            BackColor = Color.Red;
            Width = Alma.Méret;
            Height = Alma.Méret;
        }
    }
}
