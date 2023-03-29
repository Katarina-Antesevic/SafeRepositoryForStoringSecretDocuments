using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace KRZ
{
    public partial class SignUpForma : Form
    {
        public SignUpForma()
        {
            InitializeComponent();
            FillComboBox();
        }

        public static void IssueCertificate(string username, String keyDir)
        {
            System.Console.WriteLine();
            Directory.SetCurrentDirectory($"{Functions.CERTIFICATES_ROOT}");
            Functions.ExecutePowerShellCommand($"openssl req -new -key {keyDir}\\{username}\\{username}.key -config openssl.cnf -out requests//{username}.csr", true);
            Functions.ExecutePowerShellCommand($"openssl ca -in requests\\{username}.csr -out {Functions.CERTIFICATES_ROOT}\\{username}.crt -config openssl.cnf", true);
            Directory.SetCurrentDirectory($"{Functions.ROOT_FOLDER}");
            System.Console.Clear();
        }

        void FillComboBox()
        {
            var datasource = new List<String>();
            datasource.Add("SHA-256");
            datasource.Add("SHA-512");
            datasource.Add("MD5");

            this.hashCB.DataSource = datasource;

            var dataSourceII = new List<String>();
            dataSourceII.Add("aes-128-cbc");
            dataSourceII.Add("aes-128-cfb");
            dataSourceII.Add("aes-128-cfb1");
            dataSourceII.Add("aes-128-cfb8");
            dataSourceII.Add("aes-128-ctr");
            dataSourceII.Add("aes-128-ecb");
            dataSourceII.Add("aes-128-ofb");

            dataSourceII.Add("aes-192-cbc");
            dataSourceII.Add("aes-192-cfb");
            dataSourceII.Add("aes-192-cfb1");
            dataSourceII.Add("aes-192-cfb8");
            dataSourceII.Add("aes-192-ctr");
            dataSourceII.Add("aes-192-ecb");
            dataSourceII.Add("aes-192-ofb");

            dataSourceII.Add("aes-256-cbc");
            dataSourceII.Add("aes-256-cfb");
            dataSourceII.Add("aes-256-cfb1");
            dataSourceII.Add("aes-256-cfb8");
            dataSourceII.Add("aes-256-ctr");
            dataSourceII.Add("aes-256-ecb");
            dataSourceII.Add("aes-256-ofb");

            dataSourceII.Add("aes128");

            dataSourceII.Add("aes192");

            dataSourceII.Add("aes256");

            dataSourceII.Add("aria-128-cbc");
            dataSourceII.Add("aria-128-cfb");
            dataSourceII.Add("aria-128-cfb1");
            dataSourceII.Add("aria-128-cfb8");
            dataSourceII.Add("aria-128-ctr");
            dataSourceII.Add("aria-128-ecb");
            dataSourceII.Add("aria-128-ofb");

            dataSourceII.Add("aria-192-cbc");
            dataSourceII.Add("aria-192-cfb");
            dataSourceII.Add("aria-192-cfb1");
            dataSourceII.Add("aria-192-cfb8");
            dataSourceII.Add("aria-192-ctr");
            dataSourceII.Add("aria-192-ecb");
            dataSourceII.Add("aria-192-ofb");

            dataSourceII.Add("aria-256-cbc");
            dataSourceII.Add("aria-256-cfb");
            dataSourceII.Add("aria-256-cfb1");
            dataSourceII.Add("aria-256-cfb8");
            dataSourceII.Add("aria-256-ctr");
            dataSourceII.Add("aria-256-ecb");
            dataSourceII.Add("aria-256-ofb");

            dataSourceII.Add("aria128");
            dataSourceII.Add("aria192");
            dataSourceII.Add("aria256");

            dataSourceII.Add("camellia-128-cbc");
            dataSourceII.Add("camellia-128-cfb");
            dataSourceII.Add("camellia-128-cfb1");
            dataSourceII.Add("camellia-128-cfb8");
            dataSourceII.Add("camellia-128-ctr");
            dataSourceII.Add("camellia-128-ecb");
            dataSourceII.Add("camellia-128-ofb");

            dataSourceII.Add("camellia-192-cbc");
            dataSourceII.Add("camellia-192-cfb");
            dataSourceII.Add("camellia-192-cfb1");
            dataSourceII.Add("camellia-192-cfb8");
            dataSourceII.Add("camellia-192-ctr");
            dataSourceII.Add("camellia-192-ecb");
            dataSourceII.Add("camellia-192-ofb");

            dataSourceII.Add("camellia-256-cbc");
            dataSourceII.Add("camellia-256-cfb");
            dataSourceII.Add("camellia-256-cfb1");
            dataSourceII.Add("camellia-256-cfb8");
            dataSourceII.Add("camellia-256-ctr");
            dataSourceII.Add("camellia-256-ecb");
            dataSourceII.Add("camellia-256-ofb");

            dataSourceII.Add("camellia128");
            dataSourceII.Add("camellia192");
            dataSourceII.Add("camellia256");

            dataSourceII.Add("chacha20");

            dataSourceII.Add("des3");

            dataSourceII.Add("sm4");
            dataSourceII.Add("sm4-cbc");
            dataSourceII.Add("sm4-cfb");
            dataSourceII.Add("sm4-ctr");
            dataSourceII.Add("sm4-ecb");
            dataSourceII.Add("sm4-ofb");

            this.encCB.DataSource = dataSourceII;

        }

        private void kreirajNalogButton_Click(object sender, EventArgs e)
        {
            if(!korImeTextBox.Text.Equals("") && !lozinkaTextBox.Text.Equals("") && !potvrdaLozinkeTextBox.Text.Equals(""))
            {
                DirectoryInfo df = new DirectoryInfo("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO");
                var files = df.GetFiles();
                var directories = df.GetDirectories();
                bool flag = false;
                foreach (var x in files)
                {
                    if((x.Name.Substring(0, x.Name.LastIndexOf('.'))).Equals(korImeTextBox.Text))
                    {
                        flag = true;
                    }
                }

                if (flag)
                {
                    MessageBox.Show("Korisničko ime postoji!");
                    korImeTextBox.Text = "";
                }
                else
                {
                    if (lozinkaTextBox.Text.Equals(potvrdaLozinkeTextBox.Text))
                    {
                        try
                        {


                            Functions.executeCommandReturn("/c " + "generateDirForUsers.sh " + korImeTextBox.Text);
                            Functions.executeCommandReturn("/c " + "generateKeysForUsers.sh " + korImeTextBox.Text);
                            Functions.executeCommandReturn("/c " + "generatePublicKeys.sh " + korImeTextBox.Text);

                            DirectoryInfo di = Directory.CreateDirectory("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + korImeTextBox.Text + "\\fajlovi");


                            Functions.executeCommandReturn("/c " + "genereateRequest.sh " + korImeTextBox.Text);
                            
                            Functions.executeCommandReturn("/c " + "genereateCertificate.sh " + korImeTextBox.Text);


                            String hashSelected = hashCB.SelectedItem.ToString();
                            String encSelected = encCB.SelectedItem.ToString();
                            string command = "";
                            if (hashSelected.Equals("MD5"))
                                command = "/c openssl passwd -1 -salt 12345678 " + lozinkaTextBox.Text;
                            else if (hashSelected.Equals("SHA-512"))
                                command = "/c openssl passwd -6 -salt 12345678 " + lozinkaTextBox.Text;
                            else
                                command = "/c openssl passwd -5 -salt 12345678 " + lozinkaTextBox.Text;
                            String passHash = (Functions.executeCommandReturn(command)).Trim();
                            String[] lines = { korImeTextBox.Text, passHash, hashSelected, encSelected };
                            File.WriteAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO\\" + korImeTextBox.Text + ".txt", lines);

                            MessageBox.Show("Nalog sa korisničkim imenom " + korImeTextBox.Text + " je kreiran!");

                            PocetnaForma pf = new PocetnaForma();
                            pf.Show();
                            this.Hide();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Nalog nije kreiran!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Potvrda lozinke nije uspješna!");
                        lozinkaTextBox.Text = "";
                        potvrdaLozinkeTextBox.Text = "";
                    }
                }



            }
            else
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }

            

        }

        private void SignUpForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            PocetnaForma pf = new PocetnaForma();
            pf.Show();
            this.Hide();
        }
    }
}
