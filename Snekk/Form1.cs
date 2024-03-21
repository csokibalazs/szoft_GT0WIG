namespace Snekk
{
    public partial class Form1 : Form
    {
        int lépésszám; //0 a kezdõérték iniciálás nélkül
        int hossz = 1;

        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;

        Random rnd = new();

        List<Kígyóelem> kígyó = new();
        List<Alma> almák = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövelés
            fej_x += irány_x * Kígyóelem.Méret;
            fej_y += irány_y * Kígyóelem.Méret;


            //Ütközésvizsgálat
            foreach (object item in Controls) //Azért kell mert ha van más is a controlsban, nem tud vele mit kezdeni a foreach (Kígyóelem in Controls)
            {
                if (item is Kígyóelem)
                {
                    Kígyóelem k = (Kígyóelem)item;
                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Game over");
                        return;
                    }
                }
                else if (item is Alma)
                {
                    Alma a = (Alma)item;
                    if (a.Top == fej_y && a.Left == fej_x)
                    {
                        Controls.Remove(a);
                        hossz++;
                    }
                }
            }

            //Kígyó fej mozgatása
            Kígyóelem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            kígyó.Add(ke);

            //Kígyó farok levágása
            if (kígyó.Count > hossz)
            {
                Kígyóelem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            //Kígyó színezése
            if (lépésszám % 2 == 0)
            {
                ke.BackColor = Color.Green;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
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