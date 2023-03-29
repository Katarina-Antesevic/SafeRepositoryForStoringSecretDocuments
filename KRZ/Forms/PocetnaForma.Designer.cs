
namespace KRZ
{
    partial class PocetnaForma
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
            this.signUp = new System.Windows.Forms.Button();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KRIPTOGRAFIJA I RAČUNARSKA ZAŠTITA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "KATARINA ANTEŠEVIĆ";
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.LightBlue;
            this.signUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.Location = new System.Drawing.Point(164, 122);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(169, 43);
            this.signUp.TabIndex = 2;
            this.signUp.Text = "KREIRAJTE NALOG";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // prijavaButton
            // 
            this.prijavaButton.BackColor = System.Drawing.Color.LightBlue;
            this.prijavaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijavaButton.Location = new System.Drawing.Point(164, 205);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(169, 43);
            this.prijavaButton.TabIndex = 3;
            this.prijavaButton.Text = "PRIJAVA NA SISTEM";
            this.prijavaButton.UseVisualStyleBackColor = false;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KRZ.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(504, 361);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PocetnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PocetnaForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Button prijavaButton;
    }
}

