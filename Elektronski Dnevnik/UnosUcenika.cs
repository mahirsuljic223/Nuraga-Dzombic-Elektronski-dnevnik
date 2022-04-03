using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class UnosUcenika : Form
    {
        public UnosUcenika()
        {
            InitializeComponent();
        }

        private void UnosUcenika_Load(object sender, EventArgs e)
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

                values.Insert(6, num_vladanje.Value.ToString());

                Table.Insert("Ucenici", Properties.Settings.Default.Tables[1], values);

                MessageBox.Show("Učenik uspješno dodan!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void tb_prezime_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tb_ime.Text) && !String.IsNullOrWhiteSpace(tb_ime.Text))
                    tb_username.Text = tb_ime.Text.ToLower() + "." + tb_prezime.Text.ToLower() + ".online";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnosUcenika_FormClosing(object sender, FormClosingEventArgs e)
        {
            Table.LoadTables();
        }
    }
}