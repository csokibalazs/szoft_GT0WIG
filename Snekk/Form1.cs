namespace Snekk
{
    public partial class Form1 : Form
    {
        int lépésszám; //0 a kezdõérték iniciálás nélkül

        List<Kígyóelem> kígyó1 = new();
        int hossz1 = 1;
        int fej_x1 = 300;
        int fej_y1 = 300;
        int irány_x1 = 0;
        int irány_y1 = -1;

        List<Kígyóelem> kígyó2 = new();
        int hossz2 = 1;
        int fej_x2 = 500;
        int fej_y2 = 500;
        int irány_x2 = 0;
        int irány_y2 = 1;

        List<Alma> almák = new();
        Random rnd = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövelés
            fej_x1 += irány_x1 * Kígyóelem.Méret;
            fej_y1 += irány_y1 * Kígyóelem.Méret;

            fej_x2 += irány_x2 * Kígyóelem.Méret;
            fej_y2 += irány_y2 * Kígyóelem.Méret;




            //Ütközésvizsgálat
            foreach (object item in Controls) //Azért kell mert ha van más is a controlsban, nem tud vele mit kezdeni a foreach (Kígyóelem in Controls)
            {
                if (item is Kígyóelem)
                {
                    Kígyóelem k = (Kígyóelem)item;
                    if (k.Top == fej_y1 && k.Left == fej_x1)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Game over");
                        return;
                    }
                    else if (k.Top == fej_y2 && k.Left == fej_x2)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Game over");
                        return;
                    }
                }

                else if (item is Alma)
                {
                    Alma a = (Alma)item;
                    if (a.Top == fej_y1 && a.Left == fej_x1)
                    {
                        Controls.Remove(a);
                        hossz1++;
                    }
                    else if (a.Top == fej_y2 && a.Left == fej_x2)
                    {
                        Controls.Remove(a);
                        hossz2++;
                    }
                }
            }

            //Kígyó fej mozgatása
            Kígyóelem ke1 = new();
            ke1.Top = fej_y1;
            ke1.Left = fej_x1;
            Controls.Add(ke1);
            kígyó1.Add(ke1);

            Kígyóelem ke2 = new();
            ke2.Top = fej_y2;
            ke2.Left = fej_x2;
            ke2.BackColor = Color.DarkRed;
            Controls.Add(ke2);
            kígyó2.Add(ke2);



            //Kígyó farok levágása
            if (kígyó1.Count > hossz1)
            {
                Kígyóelem levágandó = kígyó1[0];
                kígyó1.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (kígyó2.Count > hossz2)
            {
                Kígyóelem levágandó = kígyó2[0];
                kígyó2.RemoveAt(0);
                Controls.Remove(levágandó);
            }


            //Kígyó színezése
            if (lépésszám % 2 == 0)
            {
                ke1.BackColor = Color.Green;
            }

            if (lépésszám % 2 == 0)
            {
                ke2.BackColor = Color.Green;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y1 = -1;
                irány_x1 = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y1 = 1;
                irány_x1 = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y1 = 0;
                irány_x1 = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y1 = 0;
                irány_x1 = 1;
            }
            if (e.KeyCode == Keys.W)
            {
                irány_y2 = -1;
                irány_x2 = 0;
            }

            if (e.KeyCode == Keys.S)
            {
                irány_y2 = 1;
                irány_x2 = 0;
            }

            if (e.KeyCode == Keys.A)
            {
                irány_y2 = 0;
                irány_x2 = -1;
            }

            if (e.KeyCode == Keys.D)
            {
                irány_y2 = 0;
                irány_x2 = 1;
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            Alma a = new();
            a.Top = rnd.Next(1, 20) * Alma.Méret;
            a.Left = rnd.Next(1, 20) * Alma.Méret;
            Controls.Add(a);


        }
    }
}