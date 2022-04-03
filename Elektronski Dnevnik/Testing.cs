using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektronski_Dnevnik
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            DataTable data = Properties.Settings.Default.Tables[1];

            string cols = String.Empty;

            foreach (DataRow row in data.Rows)
                cols += row[1].ToString() + " " + row[2].ToString() + "\n";

            MessageBox.Show(cols);
        }
    }
}
