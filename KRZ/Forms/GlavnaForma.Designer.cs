
namespace KRZ
{
    partial class GlavnaForma
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.gornjiText = new System.Windows.Forms.Label();
            this.preuzimanjeFajlaButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.odjavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(21, 50);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(381, 324);
            this.listBox.TabIndex = 0;
            // 
            // gornjiText
            // 
            this.gornjiText.AutoSize = true;
            this.gornjiText.BackColor = System.Drawing.Color.Transparent;
            this.gornjiText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gornjiText.Location = new System.Drawing.Point(29, 9);
            this.gornjiText.Name = "gornjiText";
            this.gornjiText.Size = new System.Drawing.Size(160, 24);
            this.gornjiText.TabIndex = 1;
            this.gornjiText.Text = "Fajlovi korisnika";
            // 
            // preuzimanjeFajlaButton
            // 
            this.preuzimanjeFajlaButton.BackColor = System.Drawing.Color.LightBlue;
            this.preuzimanjeFajlaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preuzimanjeFajlaButton.Location = new System.Drawing.Point(424, 50);
            this.preuzimanjeFajlaButton.Name = "preuzimanjeFajlaButton";
            this.preuzimanjeFajlaButton.Size = new System.Drawing.Size(161, 48);
            this.preuzimanjeFajlaButton.TabIndex = 2;
            this.preuzimanjeFajlaButton.Text = "Preuzimanje fajla ";
            this.preuzimanjeFajlaButton.UseVisualStyleBackColor = false;
            this.preuzimanjeFajlaButton.Click += new System.EventHandler(this.preuzimanjeFajlaButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(424, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodavanje fajla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // odjavaButton
            // 
            this.odjavaButton.BackColor = System.Drawing.Color.Salmon;
            this.odjavaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odjavaButton.Location = new System.Drawing.Point(424, 326);
            this.odjavaButton.Name = "odjavaButton";
            this.odjavaButton.Size = new System.Drawing.Size(161, 48);
            this.odjavaButton.TabIndex = 4;
            this.odjavaButton.Text = "ODJAVA SA SISTEMA";
            this.odjavaButton.UseVisualStyleBackColor = false;
            this.odjavaButton.Click += new System.EventHandler(this.odjavaButton_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KRZ.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(596, 401);
            this.Controls.Add(this.odjavaButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.preuzimanjeFajlaButton);
            this.Controls.Add(this.gornjiText);
            this.Controls.Add(this.listBox);
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label gornjiText;
        private System.Windows.Forms.Button preuzimanjeFajlaButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button odjavaButton;
    }
}