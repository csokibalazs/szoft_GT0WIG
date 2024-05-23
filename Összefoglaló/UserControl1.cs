using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Összefoglaló
{
    public partial class UserControl1 : UserControl
    {
        //StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //var er = from x in context.Instructors
                  //   select x.Name;

            //listBox1.DataSource = er.ToList();
            listBox1.DisplayMember = "Name";
        }
    }
}
