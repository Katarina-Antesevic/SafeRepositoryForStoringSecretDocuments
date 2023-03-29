
namespace KRZ
{
    partial class DigitalniSertifikatForma
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
            this.putanjaTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite putanju do Vašeg sertifikata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "kao File separator koristite \"\\\\\"";
            // 
            // putanjaTextBox
            // 
            this.putanjaTextBox.Location = new System.Drawing.Point(12, 89);
            this.putanjaTextBox.Name = "putanjaTextBox";
            this.putanjaTextBox.Size = new System.Drawing.Size(541, 20);
            this.putanjaTextBox.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.LightBlue;
            this.okButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(217, 137);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(139, 35);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // DigitalniSertifikatForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KRZ.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(565, 184);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.putanjaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DigitalniSertifikatForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DigitalniSertifikatForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox putanjaTextBox;
        private System.Windows.Forms.Button okButton;
    }
}