using _9.gyak.Models;

namespace _9.gyak
{
    public partial class FormMentes : Form
    {
        Models.StudentContext studentcontext = new();
        public FormMentes()
        {
            InitializeComponent();
            dataGridView1.DataSource = studentBindingSource;
            studentBindingSource.DataSource = studentcontext.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentcontext.SaveChanges();
            }
            catch (Exception kivétel)
            {
                MessageBox.Show(kivétel.InnerException.Message);
            }
        }
    }
}