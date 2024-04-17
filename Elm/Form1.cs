using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Elm
{
    public partial class Form1 : Form
    {
        BindingList<Futók> futók = new();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = futókBindingSource; //!!!!!!
            futókBindingSource.DataSource = futók;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Futóadatok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Futók>();

                foreach (var item in t)
                {
                    futók.Add(item);
                }

                sr.Close(); //!!! vagy nem kell ha using-ot használunk
            }
            catch (Exception ex) //alapból nem vesz át az exceptiont, ezért kell az "ex"
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMentés_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(sf.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futók);


                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (futókBindingSource.Current == null) return;

            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futókBindingSource.RemoveCurrent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormÚjFutó formÚjFutó = new FormÚjFutó();

            if (formÚjFutó.ShowDialog() == DialogResult.OK)
            {
                futókBindingSource.Add(formÚjFutó.ÚjFutó); //itt kell elmenteni ebben a formban
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double összeg = 0;
            int darab = 0;
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in futók)
            {
                if (item.Nemzetiseg == "USA")
                {
                    összeg += item.EredmenyPerc;
                    darab++;
                }
            }

            foreach (var item in futók)
            {
                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }
            }

            MessageBox.Show($"A legjobb idő {minimum}");

            double átlag = összeg / darab; //futók.Count
        }
    }
}
