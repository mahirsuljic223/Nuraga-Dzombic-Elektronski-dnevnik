using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class PregledUcenika : Form
    {
        public PregledUcenika()
        {
            InitializeComponent();
        }

        private void PregledUcenika_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Properties.Settings.Default.backgroundColor;

                AutoCompleteStringCollection names = new AutoCompleteStringCollection();

                foreach (DataRow row in Properties.Settings.Default.Tables[1].Rows)
                {
                    cb_ucenik.Items.Add(row[1].ToString() + " " + row[2].ToString());
                    names.Add(row[1].ToString() + " " + row[2].ToString());
                }

                cb_ucenik.AutoCompleteCustomSource = names;
                cb_ucenik.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                if (cb_ucenik.Items.Count > 0)
                    cb_ucenik.SelectedIndex = 0;
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
                List<string> cols = new List<string>();

                for (int i = 1; i <= 11; i++)
                    cols.Add(Properties.Settings.Default.Tables[1].Columns[i].ColumnName);

                List<string> values = new List<string>();

                foreach (TextBox tb in Controls.OfType<TextBox>())
                    values.Add(tb.Text);

                values.Reverse();

                values.Insert(6, num_vladanje.Value.ToString());

                string ID = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][0].ToString();

                Table.Update("Ucenici", cols, values, ID);
                Table.LoadTables();

                MessageBox.Show("Podaci uspješno spremljeni!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IspisPodataka()
        {
            try
            {
                tb_ime.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][1].ToString();
                tb_prezime.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][2].ToString();
                tb_adresa.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][3].ToString();
                tb_grad.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][4].ToString();
                tb_username.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][5].ToString();
                tb_brojTelefona.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][6].ToString();
                num_vladanje.Value = Convert.ToInt32(Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][7]);
                tb_imeOca.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][8].ToString();
                tb_imeMajke.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][9].ToString();
                tb_brojRoditelja.Text = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][10].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IspisOcjena()
        {
            try
            {
                string trenutniPredmet = String.Empty;
                string trenutniIspis = String.Empty;
                int y = 0;

                for (int i = 0; i < Properties.Settings.Default.Tables[1].Columns.Count - 11; i++)
                {
                    trenutniPredmet = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][11 + i].ToString();

                    trenutniIspis = Properties.Settings.Default.Tables[0].Rows[i][1].ToString() + " : ";

                    if (!String.IsNullOrEmpty(trenutniPredmet) && !String.IsNullOrWhiteSpace(trenutniPredmet))
                    {
                        string[] trenutneOcjene = trenutniPredmet.Split(';');

                        float zbir = 0f;

                        foreach (string s in trenutneOcjene)
                            zbir += Convert.ToInt32(s);

                        trenutniIspis += trenutniPredmet.Replace(';', ',') + "\n\tProsjek : " + (zbir / trenutneOcjene.Length).ToString("n2") + "\n";
                    }
                    else
                        trenutniIspis += "Nema ocijena!\n";

                    Label label = new Label();
                    label.Text = trenutniIspis;
                    label.Visible = true;
                    label.AutoSize = true;
                    label.Location = new Point(0, y);

                    y += 30;

                    panel_ocjene.Controls.Add(label);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_ucenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                panel_ocjene.Controls.Clear();

                IspisPodataka();
                IspisOcjena();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_ucenik_KeyPress(object sender, KeyPressEventArgs e)
        {
            cb_ucenik.DroppedDown = true;
        }
    }
}