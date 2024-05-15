namespace MAze
{
    public partial class Form1 : Form
    {
        PictureBox játékos = new();
        List<PictureBox> bricks = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("maze1.txt");
            int s = 0;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                for (int o = 0; o < sor.Length; o++)
                {
                    if (sor[o] == '#') //ha kiszedem akkor sima karakter lesz, idézőjelbe, stringek mennek macskakörömbe
                    {
                        PictureBox pb = new PictureBox();
                        pb.Top = s * 20;
                        pb.Left = o * 20;
                        pb.Width = 20;
                        pb.Height = 20;

                        pb.BackColor = Color.Fuchsia;

                        Controls.Add(pb);
                        bricks.Add(pb);
                    }
                }
                s++;
            }
            sr.Close();

            //-----------
            játékos.Height = 20;
            játékos.Width = 20;
            játékos.BackColor = Color.Black;

            Controls.Add(játékos);

            this.KeyDown += Form1_KeyDown; //this.Keydown tab tab

        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            int x = játékos.Location.X;
            int y = játékos.Location.Y;

            if (e.KeyCode == Keys.Left)
            {
                x -= 20;
            }
            if (e.KeyCode == Keys.Right)
            {
                x += 20;
            }
            if (e.KeyCode == Keys.Up)
            {
                y -= 20;
            }
            if (e.KeyCode == Keys.Down)
            {
                y += 20;
            }

            //var brick = bricks.FirstOrDefault(b -> b.Left == x && b.Top == y);

            var brick = (from s in bricks
                         where s.Left == x && s.Top == y
                         select s).FirstOrDefault();
            if (brick == null)
            {
                játékos.Left = x;
                játékos.Top = y;
            }

        }
    }
}
