namespace Snekk
{
    public partial class Form1 : Form
    {
        int l�p�ssz�m; //0 a kezd��rt�k inici�l�s n�lk�l

        List<K�gy�elem> k�gy�1 = new();
        int hossz1 = 1;
        int fej_x1 = 300;
        int fej_y1 = 300;
        int ir�ny_x1 = 0;
        int ir�ny_y1 = -1;

        List<K�gy�elem> k�gy�2 = new();
        int hossz2 = 1;
        int fej_x2 = 500;
        int fej_y2 = 500;
        int ir�ny_x2 = 0;
        int ir�ny_y2 = 1;

        List<Alma> alm�k = new();
        Random rnd = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            //Fejn�vel�s
            fej_x1 += ir�ny_x1 * K�gy�elem.M�ret;
            fej_y1 += ir�ny_y1 * K�gy�elem.M�ret;

            fej_x2 += ir�ny_x2 * K�gy�elem.M�ret;
            fej_y2 += ir�ny_y2 * K�gy�elem.M�ret;




            //�tk�z�svizsg�lat
            foreach (object item in Controls) //Az�rt kell mert ha van m�s is a controlsban, nem tud vele mit kezdeni a foreach (K�gy�elem in Controls)
            {
                if (item is K�gy�elem)
                {
                    K�gy�elem k = (K�gy�elem)item;
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

            //K�gy� fej mozgat�sa
            K�gy�elem ke1 = new();
            ke1.Top = fej_y1;
            ke1.Left = fej_x1;
            Controls.Add(ke1);
            k�gy�1.Add(ke1);

            K�gy�elem ke2 = new();
            ke2.Top = fej_y2;
            ke2.Left = fej_x2;
            ke2.BackColor = Color.DarkRed;
            Controls.Add(ke2);
            k�gy�2.Add(ke2);



            //K�gy� farok lev�g�sa
            if (k�gy�1.Count > hossz1)
            {
                K�gy�elem lev�gand� = k�gy�1[0];
                k�gy�1.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (k�gy�2.Count > hossz2)
            {
                K�gy�elem lev�gand� = k�gy�2[0];
                k�gy�2.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }


            //K�gy� sz�nez�se
            if (l�p�ssz�m % 2 == 0)
            {
                ke1.BackColor = Color.Green;
            }

            if (l�p�ssz�m % 2 == 0)
            {
                ke2.BackColor = Color.Green;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y1 = -1;
                ir�ny_x1 = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y1 = 1;
                ir�ny_x1 = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y1 = 0;
                ir�ny_x1 = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y1 = 0;
                ir�ny_x1 = 1;
            }
            if (e.KeyCode == Keys.W)
            {
                ir�ny_y2 = -1;
                ir�ny_x2 = 0;
            }

            if (e.KeyCode == Keys.S)
            {
                ir�ny_y2 = 1;
                ir�ny_x2 = 0;
            }

            if (e.KeyCode == Keys.A)
            {
                ir�ny_y2 = 0;
                ir�ny_x2 = -1;
            }

            if (e.KeyCode == Keys.D)
            {
                ir�ny_y2 = 0;
                ir�ny_x2 = 1;
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