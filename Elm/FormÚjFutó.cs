using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elm
{
    public partial class FormÚjFutó : Form
    {
        public Futók ÚjFutó = new Futók();

        public FormÚjFutó()
        {
            InitializeComponent();
            futókBindingSource.DataSource = ÚjFutó;
        }

        private void FormÚjFutó_Load(object sender, EventArgs e)
        {

        }
    }
}
