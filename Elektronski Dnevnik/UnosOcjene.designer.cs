
namespace Elektronski_Dnevnik
{
    partial class UnosOcjene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosOcjene));
            this.cb_ucenik = new System.Windows.Forms.ComboBox();
            this.cb_predmet = new System.Windows.Forms.ComboBox();
            this.num_ocjena = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_ocjena)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ucenik
            // 
            this.cb_ucenik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ucenik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_ucenik.FormattingEnabled = true;
            this.cb_ucenik.Location = new System.Drawing.Point(79, 8);
            this.cb_ucenik.Name = "cb_ucenik";
            this.cb_ucenik.Size = new System.Drawing.Size(183, 21);
            this.cb_ucenik.TabIndex = 0;
            this.cb_ucenik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_ucenik_KeyPress);
            // 
            // cb_predmet
            // 
            this.cb_predmet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_predmet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_predmet.FormattingEnabled = true;
            this.cb_predmet.Location = new System.Drawing.Point(79, 35);
            this.cb_predmet.Name = "cb_predmet";
            this.cb_predmet.Size = new System.Drawing.Size(183, 21);
            this.cb_predmet.TabIndex = 1;
            this.cb_predmet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_predmet_KeyPress);
            // 
            // num_ocjena
            // 
            this.num_ocjena.Location = new System.Drawing.Point(79, 62);
            this.num_ocjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_ocjena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_ocjena.Name = "num_ocjena";
            this.num_ocjena.Size = new System.Drawing.Size(183, 20);
            this.num_ocjena.TabIndex = 2;
            this.num_ocjena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_ocjena.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Učenik";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Predmet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ocjena";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(137, 88);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 40);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Spremi";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(12, 88);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(125, 40);
            this.btn_reset.TabIndex = 19;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // UnosOcjene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 141);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_ocjena);
            this.Controls.Add(this.cb_predmet);
            this.Controls.Add(this.cb_ucenik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UnosOcjene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos ocjene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnosOcjene_FormClosing);
            this.Load += new System.EventHandler(this.UnosOcjene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_ocjena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ucenik;
        private System.Windows.Forms.ComboBox cb_predmet;
        private System.Windows.Forms.NumericUpDown num_ocjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
    }
}