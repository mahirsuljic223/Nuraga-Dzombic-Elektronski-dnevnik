using System;
using System.IO;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("ElektronskiDnevnik.accdb"))
                    Table.LoadTables();
                else
                {
                    MessageBox.Show("Baza podataka ne postoji!\n\nMolimo premjestite odgovarajuću bazu podataka na sljedeću lokaciju :\n" +
                        Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Unos
        private void btn_unosUcenika_Click(object sender, EventArgs e)
        {
            UnosUcenika form = new UnosUcenika();
            form.Show();
        }

        private void btn_unosPredmeta_Click(object sender, EventArgs e)
        {
            UnosPredmeta form = new UnosPredmeta();
            form.Show();
        }

        private void btn_unosOcjene_Click(object sender, EventArgs e)
        {
            UnosOcjene form = new UnosOcjene();
            form.Show();
        }
        #endregion

        #region Pregled
        private void btn_pregledUcenika_Click(object sender, EventArgs e)
        {
            PregledUcenika form = new PregledUcenika();
            form.Show();
        }

        private void btn_pregledPredmeta_Click(object sender, EventArgs e)
        {
            PregledPredmeta form = new PregledPredmeta();
            form.Show();
        }

        private void btn_pregledSvihUcenika_Click(object sender, EventArgs e)
        {
            PregledSvihUcenika form = new PregledSvihUcenika();
            form.Show();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Testing form = new Testing();
            form.Show();
        }
    }
}