
namespace KRZ
{
    partial class DodavanjaFajlaForm
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
            this.odabirFajlaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odabirFajlaButton
            // 
            this.odabirFajlaButton.BackColor = System.Drawing.Color.LightBlue;
            this.odabirFajlaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odabirFajlaButton.Location = new System.Drawing.Point(178, 125);
            this.odabirFajlaButton.Name = "odabirFajlaButton";
            this.odabirFajlaButton.Size = new System.Drawing.Size(157, 45);
            this.odabirFajlaButton.TabIndex = 0;
            this.odabirFajlaButton.Text = "ODABIR FAJLA";
            this.odabirFajlaButton.UseVisualStyleBackColor = false;
            this.odabirFajlaButton.Click += new System.EventHandler(this.odabirFajlaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite fajl koji želite dodati";
            // 
            // DodavanjaFajlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KRZ.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(529, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odabirFajlaButton);
            this.Name = "DodavanjaFajlaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodavanjaFajlaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odabirFajlaButton;
        private System.Windows.Forms.Label label1;
    }
}