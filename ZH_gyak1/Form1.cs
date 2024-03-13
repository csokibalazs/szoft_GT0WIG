namespace ZH_gyak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sorokSzáma = int.Parse(textBox1.Text);

            Random rnd = new Random();
            List<RácsEgySora> sorok = new List<RácsEgySora>();

            for (int i = 0; i < 10; i++)
            {
                int véletlen = rnd.Next(1, 7);
                RácsEgySora rácsEgySora = new RácsEgySora();
                rácsEgySora.Sorszám = i;
                rácsEgySora.VéletlenSzám = véletlen;
                rácsEgySora.Fibo = Fibonacci(i);

                sorok.Add(rácsEgySora);
            }

            int Fibonacci(int n)
            {
                if (n == 0) return 1;
                if (n == 1) return 1;
                return Fibonacci(n - 1); +Fibonacci(n - 2);
            }

            dataGridView1.DataSource = sorok;
        }
    }
}
