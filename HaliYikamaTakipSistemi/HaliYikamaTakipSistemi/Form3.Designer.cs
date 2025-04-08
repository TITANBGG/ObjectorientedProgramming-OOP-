namespace HaliYikamaTakipSistemi
{
    partial class FormDurumTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDurumTakip));
            this.btnDurumGuncelleme = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnYikamada = new System.Windows.Forms.Button();
            this.btnTeslimEdilen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDurumGuncelleme
            // 
            this.btnDurumGuncelleme.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDurumGuncelleme.Location = new System.Drawing.Point(244, 293);
            this.btnDurumGuncelleme.Name = "btnDurumGuncelleme";
            this.btnDurumGuncelleme.Size = new System.Drawing.Size(122, 82);
            this.btnDurumGuncelleme.TabIndex = 0;
            this.btnDurumGuncelleme.Text = "Durum Güncelle\n";
            this.btnDurumGuncelleme.UseVisualStyleBackColor = false;
            this.btnDurumGuncelleme.Click += new System.EventHandler(this.btnDurumGuncelleme_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(415, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 212);
            this.listBox1.TabIndex = 1;
            // 
            // btnYikamada
            // 
            this.btnYikamada.BackColor = System.Drawing.Color.BurlyWood;
            this.btnYikamada.Location = new System.Drawing.Point(121, 298);
            this.btnYikamada.Name = "btnYikamada";
            this.btnYikamada.Size = new System.Drawing.Size(105, 73);
            this.btnYikamada.TabIndex = 2;
            this.btnYikamada.Text = "button1";
            this.btnYikamada.UseVisualStyleBackColor = false;
            this.btnYikamada.Click += new System.EventHandler(this.btnYikamada_Click);
            // 
            // btnTeslimEdilen
            // 
            this.btnTeslimEdilen.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTeslimEdilen.Location = new System.Drawing.Point(12, 298);
            this.btnTeslimEdilen.Name = "btnTeslimEdilen";
            this.btnTeslimEdilen.Size = new System.Drawing.Size(103, 73);
            this.btnTeslimEdilen.TabIndex = 3;
            this.btnTeslimEdilen.Text = "button2";
            this.btnTeslimEdilen.UseVisualStyleBackColor = false;
            this.btnTeslimEdilen.Click += new System.EventHandler(this.btnTeslimEdilen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormDurumTakip
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(645, 427);
            this.Controls.Add(this.btnTeslimEdilen);
            this.Controls.Add(this.btnYikamada);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDurumGuncelleme);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDurumTakip";
            this.Text = "FormDurumTakip";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHalilar;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDurumGuncelleme;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnYikamada;
        private System.Windows.Forms.Button btnTeslimEdilen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}