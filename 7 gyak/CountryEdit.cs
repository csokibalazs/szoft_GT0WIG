using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_gyak
{
    public partial class CountryEdit : Form
    {
        public CountryData CountryData;
        public CountryEdit()
        {
            InitializeComponent();
        }

        private void CountryEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }
    }
}
