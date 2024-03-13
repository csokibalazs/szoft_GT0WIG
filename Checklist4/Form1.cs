namespace Checklist4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    if (oszlop <= sor)
                    {
                        double szam = rnd.Next(1, 100);
                        if (szam < 10)
                        {
                            Piros piros = new Piros();
                            Controls.Add(piros);
                            piros.Width = m;
                            piros.BackColor = Color.Red;
                            piros.Height = m;
                            piros.Top = m * sor;
                            piros.Left = ClientRectangle.Width / 2 - (m / 2 * sor) + m * oszlop + 200;

                        }
                        else if (szam > 90)
                        {
                            Sárga sárga = new Sárga();
                            Controls.Add(sárga);
                            sárga.Width = m;
                            sárga.BackColor = Color.Yellow;
                            sárga.Height = m;
                            sárga.Top = m * sor;
                            sárga.Left = ClientRectangle.Width / 2 - (m / 2 * sor) + m * oszlop + 200;
                        }
                        else
                        {
                            Button button = new Button();
                            button.BackColor = Color.DarkGreen;
                            Controls.Add(button);
                            button.Width = m;
                            button.Height = m;
                            button.Top = m * sor;
                            button.Left = ClientRectangle.Width / 2 - (m / 2 * sor) + m * oszlop + 200;
                        }
                    }
                }
            }
            for (int sor = 0; sor < 4; sor++)
            {
                for (int oszlop = 0; oszlop < 3; oszlop++)
                {
                    Button t = new Button();
                    t.BackColor = Color.Brown;
                    t.Width = m;
                    t.Height = m;
                    t.Top = m * sor + 760;
                    t.Left = ClientRectangle.Width / 2 - m/2 + m * oszlop + 200;
                    Controls.Add(t);
                }
            }
        }
    }
}
