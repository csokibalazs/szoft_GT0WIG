namespace Snekk
{
    public partial class Form1 : Form
    {
        int l�p�ssz�m; //0 a kezd��rt�k inici�l�s n�lk�l
        int hossz = 1;

        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;

        Random rnd = new();

        List<K�gy�elem> k�gy� = new();
        List<Alma> alm�k = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            //Fejn�vel�s
            fej_x += ir�ny_x * K�gy�elem.M�ret;
            fej_y += ir�ny_y * K�gy�elem.M�ret;


            //�tk�z�svizsg�lat
            foreach (object item in Controls) //Az�rt kell mert ha van m�s is a controlsban, nem tud vele mit kezdeni a foreach (K�gy�elem in Controls)
            {
                if (item is K�gy�elem)
                {
                    K�gy�elem k = (K�gy�elem)item;
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

            //K�gy� fej mozgat�sa
            K�gy�elem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            k�gy�.Add(ke);

            //K�gy� farok lev�g�sa
            if (k�gy�.Count > hossz)
            {
                K�gy�elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            //K�gy� sz�nez�se
            if (l�p�ssz�m % 2 == 0)
            {
                ke.BackColor = Color.Green;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Alma a = new();
            a.Top = rnd.Next(1, 20) * Alma.M�ret;
            a.Left = rnd.Next(1, 20) * Alma.M�ret;
            Controls.Add(a);


        }
    }
}