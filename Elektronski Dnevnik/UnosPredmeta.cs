using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class UnosPredmeta : Form
    {
        public UnosPredmeta()
        {
            InitializeComponent();
        }

        private void UnosPredmeta_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Properties.Settings.Default.backgroundColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> values = new List<string>();

                foreach (TextBox tb in Controls.OfType<TextBox>())
                    values.Add(tb.Text);

                values.Reverse();

                Table.Insert("Predmeti", Properties.Settings.Default.Tables[0], values);
                Table.AddColumn("Ucenici", "Ocjene" + tb_naziv.Text.Replace(" ", String.Empty));

                MessageBox.Show("Predmet uspješno dodan!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TextBox tb in Controls.OfType<TextBox>())
                    tb.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnosPredmeta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Table.LoadTables();
        }
    }
}