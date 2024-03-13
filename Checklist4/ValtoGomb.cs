using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checklist4
{
    internal class ValtoGomb : Button
    {
        bool Aktiv = false;
        public ValtoGomb()
        {
            MouseClick += ValtoGomb_MouseClick;
        }

        private void ValtoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (Aktiv)
            {
                Aktiv = false;
                BackColor = SystemColors.ButtonFace;
            }
            else
            {
                Aktiv = true;
                BackColor = Color.AliceBlue;
            }
        }
    }
}
