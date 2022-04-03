
namespace Elektronski_Dnevnik
{
    partial class PregledPredmeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledPredmeta));
            this.dg_pregledPredmeta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pregledPredmeta)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_pregledPredmeta
            // 
            this.dg_pregledPredmeta.AllowUserToAddRows = false;
            this.dg_pregledPredmeta.AllowUserToDeleteRows = false;
            this.dg_pregledPredmeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pregledPredmeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_pregledPredmeta.Location = new System.Drawing.Point(0, 0);
            this.dg_pregledPredmeta.Name = "dg_pregledPredmeta";
            this.dg_pregledPredmeta.Size = new System.Drawing.Size(434, 261);
            this.dg_pregledPredmeta.TabIndex = 0;
            this.dg_pregledPredmeta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_pregledPredmeta_CellEndEdit);
            // 
            // PregledPredmeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.dg_pregledPredmeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PregledPredmeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled predmeta";
            this.Load += new System.EventHandler(this.PregledPredmeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_pregledPredmeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_pregledPredmeta;
    }
}