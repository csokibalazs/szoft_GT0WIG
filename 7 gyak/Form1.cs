using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace _7_gyak
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
            StreamReader sr = new StreamReader("Countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryEdit ce = new CountryEdit();
            ce.CountryData = countryDataBindingSource.Current as CountryData;
            ce.Show();
        }
    }
}