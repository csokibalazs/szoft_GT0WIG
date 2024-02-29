using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._hét
{
    internal class SzamoloGomb : VillogoGomb
    {
        int érték = 1; //csak alatti blokkokban érhető el, public miatt mindenhonnan
        public SzamoloGomb()
        {
            Text = érték.ToString();
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (érték < 6)
            {
                érték++;
            }
            else
            {
                érték = 1;
            }
            Text = érték.ToString();
        }
    }
}
