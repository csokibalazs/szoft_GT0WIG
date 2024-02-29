namespace _3._hét
{
    public partial class Form1 : Form
    {
        public Form1() //form1 konstruktor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button(); //létrehozunk egy példányt
            Controls.Add(b); //hozzáadjuk a formhoz

            b.Left = ClientRectangle.Width / 2 - b.Width / 2;  //ablak hasznos területének szélessége
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;
            Random rnd = new Random();

            int méret = 20;  //változó bevezetése

            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    //gomb pédányosítása
                    SzamoloGomb p = new SzamoloGomb();
                    Controls.Add(p);
                    p.Height = méret;
                    p.Width = méret;
                    p.Left = méret * oszlop;
                    p.Top = méret * sor;
                    p.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                }
            }


            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    //gomb pédányosítása
                    SzamoloGomb p = new SzamoloGomb();
                    Controls.Add(p);
                    p.Height = méret;
                    p.Width = méret;
                    p.Left = rnd.Next(1, 500);
                    p.Top = rnd.Next(1, 500);

                }
            }
        }
    }
}