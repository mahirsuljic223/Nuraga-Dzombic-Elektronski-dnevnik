using System;
using System.Data;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class UnosOcjene : Form
    {
        public UnosOcjene()
        {
            InitializeComponent();
        }

        private void UnosOcjene_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Properties.Settings.Default.backgroundColor;

                AutoCompleteStringCollection names = new AutoCompleteStringCollection();
                AutoCompleteStringCollection subjects = new AutoCompleteStringCollection();

                foreach (DataRow row in Properties.Settings.Default.Tables[1].Rows)
                {
                    cb_ucenik.Items.Add(row[1].ToString() + " " + row[2].ToString());
                    names.Add(row[1].ToString() + " " + row[2].ToString());
                }

                foreach (DataRow row in Properties.Settings.Default.Tables[0].Rows)
                {
                    cb_predmet.Items.Add(row[1].ToString());
                    subjects.Add(row[1].ToString());
                }

                cb_ucenik.AutoCompleteCustomSource = names;
                cb_ucenik.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                if (cb_ucenik.Items.Count > 0)
                    cb_ucenik.SelectedIndex = 0;

                cb_predmet.AutoCompleteCustomSource = subjects;
                cb_predmet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                if (cb_predmet.Items.Count > 0)
                    cb_predmet.SelectedIndex = 0;
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
                string col = Properties.Settings.Default.Tables[1].Columns[11 + cb_predmet.SelectedIndex].ColumnName;
                string value = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][11 + cb_predmet.SelectedIndex].ToString();
                string ID = Properties.Settings.Default.Tables[1].Rows[cb_ucenik.SelectedIndex][0].ToString();

                if (!String.IsNullOrEmpty(value) && !String.IsNullOrWhiteSpace(value))
                    value += ";";

                value += num_ocjena.Value.ToString();

                Table.Update("Ucenici", col, value, ID);
                Table.LoadTables();

                MessageBox.Show("Ocjena uspješno dodana!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                cb_ucenik.SelectedIndex = 0;
                cb_predmet.SelectedIndex = 0;
                num_ocjena.Value = num_ocjena.Maximum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnosOcjene_FormClosing(object sender, FormClosingEventArgs e)
        {
            Table.LoadTables();
        }

        private void cb_ucenik_KeyPress(object sender, KeyPressEventArgs e)
        {
            cb_ucenik.DroppedDown = true;
        }

        private void cb_predmet_KeyPress(object sender, KeyPressEventArgs e)
        {
            cb_predmet.DroppedDown = true;
        }
    }
}