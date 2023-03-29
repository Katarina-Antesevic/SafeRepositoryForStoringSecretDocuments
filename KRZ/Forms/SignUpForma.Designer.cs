
namespace KRZ
{
    partial class SignUpForma
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
            this.kreirajNalogButton = new System.Windows.Forms.Button();
            this.korImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.potvrdaLozinkeTextBox = new System.Windows.Forms.TextBox();
            this.hashCB = new System.Windows.Forms.ComboBox();
            this.encCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potvrdite lozinku";
            // 
            // kreirajNalogButton
            // 
            this.kreirajNalogButton.BackColor = System.Drawing.Color.LightBlue;
            this.kreirajNalogButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kreirajNalogButton.Location = new System.Drawing.Point(232, 292);
            this.kreirajNalogButton.Name = "kreirajNalogButton";
            this.kreirajNalogButton.Size = new System.Drawing.Size(182, 43);
            this.kreirajNalogButton.TabIndex = 3;
            this.kreirajNalogButton.Text = "KREIRAJTE NALOG";
            this.kreirajNalogButton.UseVisualStyleBackColor = false;
            this.kreirajNalogButton.Click += new System.EventHandler(this.kreirajNalogButton_Click);
            // 
            // korImeTextBox
            // 
            this.korImeTextBox.Location = new System.Drawing.Point(232, 47);
            this.korImeTextBox.Name = "korImeTextBox";
            this.korImeTextBox.Size = new System.Drawing.Size(182, 20);
            this.korImeTextBox.TabIndex = 4;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(232, 91);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(182, 20);
            this.lozinkaTextBox.TabIndex = 5;
            this.lozinkaTextBox.UseSystemPasswordChar = true;
            // 
            // potvrdaLozinkeTextBox
            // 
            this.potvrdaLozinkeTextBox.Location = new System.Drawing.Point(232, 133);
            this.potvrdaLozinkeTextBox.Name = "potvrdaLozinkeTextBox";
            this.potvrdaLozinkeTextBox.Size = new System.Drawing.Size(182, 20);
            this.potvrdaLozinkeTextBox.TabIndex = 6;
            this.potvrdaLozinkeTextBox.UseSystemPasswordChar = true;
            // 
            // hashCB
            // 
            this.hashCB.FormattingEnabled = true;
            this.hashCB.Location = new System.Drawing.Point(261, 193);
            this.hashCB.Name = "hashCB";
            this.hashCB.Size = new System.Drawing.Size(153, 21);
            this.hashCB.TabIndex = 7;
            // 
            // encCB
            // 
            this.encCB.FormattingEnabled = true;
            this.encCB.Location = new System.Drawing.Point(261, 233);
            this.encCB.Name = "encCB";
            this.encCB.Size = new System.Drawing.Size(153, 21);
            this.encCB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hash algoritam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Algoritam za enkripciju";
            // 
            // SignUpForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KRZ.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(504, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encCB);
            this.Controls.Add(this.hashCB);
            this.Controls.Add(this.potvrdaLozinkeTextBox);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.korImeTextBox);
            this.Controls.Add(this.kreirajNalogButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kreirajNalogButton;
        private System.Windows.Forms.TextBox korImeTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.TextBox potvrdaLozinkeTextBox;
        private System.Windows.Forms.ComboBox hashCB;
        private System.Windows.Forms.ComboBox encCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}