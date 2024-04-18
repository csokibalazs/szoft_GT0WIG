using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hajózás
{
    public partial class FormÚjKérdés : Form
    {
        public Kérdés ÚjKérdés = new();
        public FormÚjKérdés()
        {
            InitializeComponent();
            kérdésBindingSource.DataSource = ÚjKérdés;
            
        }

    }
}
