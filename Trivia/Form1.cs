namespace Trivia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            //Excel fájlnál be kell állítani hogy copyzza a fájlt, hogy meg tudja nyitni
            StreamReader sr = new StreamReader("jatek.csv", true);

            int kérdésszám = 0;

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();

                //string[,] tömb = new string[10, 10]; //10 elemből álló tömb, nem igazán növelhető
                //tömb[0, 0] = "alma";

                string[] elemek = sor.Split(";");

                UserControlKérdés kérdés = new UserControlKérdés(
                    elemek[0],
                    elemek[1],
                    elemek[2],
                    elemek[3],
                    elemek[4],
                    int.Parse(elemek[5])
                    );
                Controls.Add(kérdés);
                kérdés.Top = (kérdés.Height + 1) * kérdésszám;

                kérdésszám++;
                if (kérdésszám == 100) break;
            }

            sr.Close();
            //Bezárja a fájlt
        }
    }
}
