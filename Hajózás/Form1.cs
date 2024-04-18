using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Hajózás
{
    public partial class Form1 : Form
    {
        BindingList<Kérdés> kérdések = new BindingList<Kérdés>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = kérdésBindingSource;
            kérdésBindingSource.DataSource = kérdések;
        }

        private void buttonbeolvas_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Kérdések.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Kérdés>();

                foreach (var item in tömb)
                {
                    kérdések.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sf.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(kérdések);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            FormÚjKérdés formÚjKérdés = new();

            if (formÚjKérdés.ShowDialog() == DialogResult.OK)
            {
                kérdésBindingSource.Add(formÚjKérdés.ÚjKérdés);
            }
        }

        private void buttonTörlés_Click(object sender, EventArgs e)
        {
            if (kérdésBindingSource.Current == null) return;

            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kérdésBindingSource.RemoveCurrent();
            };
        }
    }
}
