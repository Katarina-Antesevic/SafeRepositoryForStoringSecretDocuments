using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRZ
{
    public partial class DigitalniSertifikatForma : Form
    {
        public DigitalniSertifikatForma()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string putanjaDoSertifikata = putanjaTextBox.Text.ToString();
            if (!File.Exists(putanjaDoSertifikata))
            {
                MessageBox.Show("Sertifikat ne postoji na datoj putanji!");

            }
            else if (!putanjaDoSertifikata.EndsWith(".crt"))
            {
                MessageBox.Show("Fajl na datoj putanju nje sertifikat");
            }
            else
            {
                var validityDate = false;
                var validityCrl = false;
                String command = "";

                validityDate = CertificateCheck.isCertificateValidDate(putanjaDoSertifikata);
                validityCrl = CertificateCheck.isCertificateValidCrl(putanjaDoSertifikata);


                if (validityDate && validityCrl)
                {
                    MessageBox.Show("Sertifikat je validan!");
                    string filePath = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ";

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, "tmp.txt")))
                    {
                            outputFile.WriteLine(putanjaDoSertifikata);
                    }


                    LogInForma lf = new LogInForma();
                    lf.Show();
                    this.Hide();

                }
                else if (!validityCrl && validityDate)
                {
                    MessageBox.Show("Sertifikat je povučen");
                }
                else
                {
                    MessageBox.Show("Sertifikat više nije važeći");
                }

            }


        }

        private void DigitalniSertifikatForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            PocetnaForma pf = new PocetnaForma();
            this.Hide();
            pf.Show();
        }
    }
}
