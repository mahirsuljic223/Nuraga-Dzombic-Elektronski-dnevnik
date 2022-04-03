
namespace Elektronski_Dnevnik
{
    partial class PregledUcenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledUcenika));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ucenik = new System.Windows.Forms.ComboBox();
            this.num_vladanje = new System.Windows.Forms.NumericUpDown();
            this.tb_brojRoditelja = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_imeMajke = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_imeOca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_brojTelefona = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_grad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_ocjene = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.num_vladanje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Učenik";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_ucenik
            // 
            this.cb_ucenik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ucenik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_ucenik.FormattingEnabled = true;
            this.cb_ucenik.Location = new System.Drawing.Point(104, 10);
            this.cb_ucenik.Name = "cb_ucenik";
            this.cb_ucenik.Size = new System.Drawing.Size(205, 21);
            this.cb_ucenik.TabIndex = 4;
            this.cb_ucenik.SelectedIndexChanged += new System.EventHandler(this.cb_ucenik_SelectedIndexChanged);
            this.cb_ucenik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_ucenik_KeyPress);
            // 
            // num_vladanje
            // 
            this.num_vladanje.Location = new System.Drawing.Point(104, 206);
            this.num_vladanje.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_vladanje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_vladanje.Name = "num_vladanje";
            this.num_vladanje.Size = new System.Drawing.Size(205, 20);
            this.num_vladanje.TabIndex = 34;
            this.num_vladanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_vladanje.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tb_brojRoditelja
            // 
            this.tb_brojRoditelja.Location = new System.Drawing.Point(104, 284);
            this.tb_brojRoditelja.Name = "tb_brojRoditelja";
            this.tb_brojRoditelja.Size = new System.Drawing.Size(205, 20);
            this.tb_brojRoditelja.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 18);
            this.label10.TabIndex = 41;
            this.label10.Text = "Broj roditelja";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_imeMajke
            // 
            this.tb_imeMajke.Location = new System.Drawing.Point(104, 258);
            this.tb_imeMajke.Name = "tb_imeMajke";
            this.tb_imeMajke.Size = new System.Drawing.Size(205, 20);
            this.tb_imeMajke.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "Ime majke";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_imeOca
            // 
            this.tb_imeOca.Location = new System.Drawing.Point(104, 232);
            this.tb_imeOca.Name = "tb_imeOca";
            this.tb_imeOca.Size = new System.Drawing.Size(205, 20);
            this.tb_imeOca.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ime oca";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Vladanje";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_brojTelefona
            // 
            this.tb_brojTelefona.Location = new System.Drawing.Point(104, 180);
            this.tb_brojTelefona.Name = "tb_brojTelefona";
            this.tb_brojTelefona.Size = new System.Drawing.Size(205, 20);
            this.tb_brojTelefona.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Broj telefona";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(104, 154);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(205, 20);
            this.tb_username.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_grad
            // 
            this.tb_grad.Location = new System.Drawing.Point(104, 128);
            this.tb_grad.Name = "tb_grad";
            this.tb_grad.Size = new System.Drawing.Size(205, 20);
            this.tb_grad.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Grad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(104, 102);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(205, 20);
            this.tb_adresa.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Adresa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_prezime
            // 
            this.tb_prezime.Location = new System.Drawing.Point(104, 76);
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(205, 20);
            this.tb_prezime.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Prezime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(104, 49);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(205, 20);
            this.tb_ime.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ime";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(15, 310);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(294, 40);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "Spremi";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(315, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "Ocjene";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_ocjene
            // 
            this.panel_ocjene.AutoScroll = true;
            this.panel_ocjene.Location = new System.Drawing.Point(318, 49);
            this.panel_ocjene.Name = "panel_ocjene";
            this.panel_ocjene.Size = new System.Drawing.Size(237, 301);
            this.panel_ocjene.TabIndex = 44;
            // 
            // PregledUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 361);
            this.Controls.Add(this.panel_ocjene);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.num_vladanje);
            this.Controls.Add(this.tb_brojRoditelja);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_imeMajke);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_imeOca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_brojTelefona);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_grad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_prezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ucenik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PregledUcenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled učenika";
            this.Load += new System.EventHandler(this.PregledUcenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_vladanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ucenik;
        private System.Windows.Forms.NumericUpDown num_vladanje;
        private System.Windows.Forms.TextBox tb_brojRoditelja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_imeMajke;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_imeOca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_brojTelefona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_grad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel_ocjene;
    }
}