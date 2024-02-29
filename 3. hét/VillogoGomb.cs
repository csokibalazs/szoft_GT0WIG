using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._hét
{
    internal class VillogoGomb : Button //buttontól örököltetjük, FONTOS
    {
        //ctor tab tab konstruktor hoz létre, lefut amikor létrehozzuk a classt
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;  //eseményhez adunk egy eseménykiszolgálót
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
           BackColor = Color.Transparent;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
