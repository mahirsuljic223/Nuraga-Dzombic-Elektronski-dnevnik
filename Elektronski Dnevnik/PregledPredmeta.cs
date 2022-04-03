using System;
using System.Data;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class PregledPredmeta : Form
    {
        public PregledPredmeta()
        {
            InitializeComponent();
        }

        private void PregledPredmeta_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Properties.Settings.Default.backgroundColor;

                DataTable table = Properties.Settings.Default.Tables[0].Copy();

                if (table.Columns[0].ColumnName == "ID")
                    table.Columns.RemoveAt(0);

                Table.DisplayDataToGrid(table, dg_pregledPredmeta);

                dg_pregledPredmeta.Columns[0].Width = dg_pregledPredmeta.Width / 2 - 45;
                dg_pregledPredmeta.Columns[1].Width = dg_pregledPredmeta.Width - dg_pregledPredmeta.Columns[0].Width - 45;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_pregledPredmeta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Table.Update("Predmeti",
                    dg_pregledPredmeta.Columns[e.ColumnIndex].HeaderText,
                    dg_pregledPredmeta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),
                    Properties.Settings.Default.Tables[0].Rows[e.RowIndex][0].ToString());

                Table.LoadTables();

                MessageBox.Show("Podaci uspješno spremljeni!", "Uspjeh!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}