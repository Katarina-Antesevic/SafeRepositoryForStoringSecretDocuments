
namespace KRZ
{
    partial class OdlukaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.buttonSertifikat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNoviNalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukoliko želite reaktivirati Vaš sertifikat, unesite ispavne kredencijale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničo ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(257, 81);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(155, 20);
            this.tbKorisnickoIme.TabIndex = 3;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(257, 119);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(155, 20);
            this.tbLozinka.TabIndex = 4;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // buttonSertifikat
            // 
            this.buttonSertifikat.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSertifikat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSertifikat.Location = new System.Drawing.Point(233, 168);
            this.buttonSertifikat.Name = "buttonSertifikat";
            this.buttonSertifikat.Size = new System.Drawing.Size(107, 38);
            this.buttonSertifikat.TabIndex = 5;
            this.buttonSertifikat.Text = "OK";
            this.buttonSertifikat.UseVisualStyleBackColor = false;
            this.buttonSertifikat.Click += new System.EventHandler(this.buttonSertifikat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "ili";
            // 
            // buttonNoviNalog
            // 
            this.buttonNoviNalog.BackColor = System.Drawing.Color.LightBlue;
            this.buttonNoviNalog.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNoviNalog.Location = new System.Drawing.Point(177, 308);
            this.buttonNoviNalog.Name = "buttonNoviNalog";
            this.buttonNoviNalog.Size = new System.Drawing.Size(215, 43);
            this.buttonNoviNalog.TabIndex = 7;
            this.buttonNoviNalog.Text = "KREIRANjE NOVOG NALOGA";
            this.buttonNoviNalog.UseVisualStyleBackColor = false;
            this.buttonNoviNalog.Click += new System.EventHandler(this.buttonNoviNalog_Click);
            // 
            // OdlukaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KRZ.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(565, 383);
            this.Controls.Add(this.buttonNoviNalog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSertifikat);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OdlukaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OdlukaForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button buttonSertifikat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNoviNalog;
    }
}