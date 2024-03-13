using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia
{
    public partial class UserControlKérdés : UserControl
    {
        int jóVálasz;
        public UserControlKérdés()
        {
            InitializeComponent();
        }

        public UserControlKérdés(string kérdés,
            string v1, 
            string v2, 
            string v3, 
            string v4,
            int jóVálasz
            )
        {
            InitializeComponent();
            //label1.Text = kérdés;
            //button1.Text = v1;
            //button2.Text = v2;
            //button3.Text = v3;
            //button4.Text = v4;

            this.jóVálasz = jóVálasz; //globális egyenlő legyen a helyivel
        }
    }
}
