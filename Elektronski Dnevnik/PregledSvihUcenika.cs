using System;
using System.Data;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class PregledSvihUcenika : Form
    {
        public PregledSvihUcenika()
        {
            InitializeComponent();
        }

        private void PregledSvihUcenika_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Properties.Settings.Default.backgroundColor;

                DataTable table = Properties.Settings.Default.Tables[1].Copy();

                if (table.Columns[0].ColumnName == "ID")
                    table.Columns.RemoveAt(0);

                Table.DisplayDataToGrid(table, dg_pregledSvihUcenika);

                dg_pregledSvihUcenika.Columns[2].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_pregledSvihUcenika_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Table.Update("Ucenici",
                    dg_pregledSvihUcenika.Columns[e.ColumnIndex].HeaderText,
                    dg_pregledSvihUcenika.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),
                    Properties.Settings.Default.Tables[1].Rows[e.RowIndex][0].ToString());

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