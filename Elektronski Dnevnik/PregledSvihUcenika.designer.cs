
namespace Elektronski_Dnevnik
{
    partial class PregledSvihUcenika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledSvihUcenika));
            this.dg_pregledSvihUcenika = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pregledSvihUcenika)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_pregledSvihUcenika
            // 
            this.dg_pregledSvihUcenika.AllowUserToAddRows = false;
            this.dg_pregledSvihUcenika.AllowUserToDeleteRows = false;
            this.dg_pregledSvihUcenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pregledSvihUcenika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_pregledSvihUcenika.Location = new System.Drawing.Point(0, 0);
            this.dg_pregledSvihUcenika.Name = "dg_pregledSvihUcenika";
            this.dg_pregledSvihUcenika.Size = new System.Drawing.Size(1259, 455);
            this.dg_pregledSvihUcenika.TabIndex = 0;
            this.dg_pregledSvihUcenika.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_pregledSvihUcenika_CellEndEdit);
            // 
            // PregledSvihUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 455);
            this.Controls.Add(this.dg_pregledSvihUcenika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PregledSvihUcenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled svih učenika";
            this.Load += new System.EventHandler(this.PregledSvihUcenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_pregledSvihUcenika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_pregledSvihUcenika;
    }
}