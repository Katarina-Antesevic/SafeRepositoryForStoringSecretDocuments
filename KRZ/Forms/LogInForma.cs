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
    public partial class LogInForma : Form
    {
        public LogInForma()
        {
            InitializeComponent();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            var kraj = false;


           
                if (!korisnickoImeTextBox.Text.Equals("") && !lozinkaTextBox.Text.Equals(""))
                {
                    string tmpFile = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\tmp.txt";
                    var lines = File.ReadAllLines(tmpFile);

                    //C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\certs\\kaca.crt
                    string t = lines[0].Split(':')[1];
                    var tts = t.Split('\\'); // Users, AcerAspireE5, ...

                    string trazenoKorisnickoIme = tts[tts.Length - 1].Split('.')[0]; //kaca
                    string filePath = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ";

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, "tmp.txt"), true))
                    {
                        outputFile.WriteLine(trazenoKorisnickoIme);
                    }

                var prviPut = true;
                    foreach (var x in lines)
                {
                    if (x.Contains("brojac"))
                    {
                        prviPut = false;
                        break;
                    }
                }

                if (!prviPut)
                {
                    brojac = int.Parse(lines[lines.Length - 1].Split('=')[1]);
                }

                    if (!trazenoKorisnickoIme.Equals(korisnickoImeTextBox.Text))
                    {
                        MessageBox.Show("Korisničko ime ne odgovara sertifikatu!");
                        brojac++;
                        korisnickoImeTextBox.Text = "";
                        lozinkaTextBox.Text = "";
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, "tmp.txt"), true))
                    {
                        outputFile.WriteLine("brojac="+brojac);
                    }

                    if (brojac < 3)
                    {
                        LogInForma lf = new LogInForma();
                        this.Hide();
                        lf.Show();
                    }

                }
                    else
                    {
                        filePath = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO\\" + trazenoKorisnickoIme + ".txt";
                        var list = File.ReadAllLines(filePath);
                        string command = "";
                        if (list[2].Equals("MD5"))
                            command = "/c openssl passwd -1 -salt 12345678 " + lozinkaTextBox.Text;
                        else if (list[2].Equals("SHA-512"))
                            command = "/c openssl passwd -6 -salt 12345678 " + lozinkaTextBox.Text;
                        else
                            command = "/c openssl passwd -5 -salt 12345678 " + lozinkaTextBox.Text;
                        String passHash = (Functions.executeCommandReturn(command)).Trim();
                        var passExists = passHash.Equals(list[1]);
                        if (!passExists)
                        {
                            brojac++;
                            MessageBox.Show("Niste unijeli dobru lozinku!");
                            lozinkaTextBox.Text = "";
                        using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ", "tmp.txt"), true))
                        {
                            outputFile.WriteLine("brojac=" + brojac);
                        }

                        if (brojac < 3)
                        {
                            LogInForma lf = new LogInForma();
                            this.Hide();
                            lf.Show();
                        }
                    }
                        else
                        {
                            if (File.Exists(tmpFile))
                            {
                                try
                                {
                                    File.Delete(tmpFile);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }

                        using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ", "trenutnoPrijavljeniKorisnik.txt"), true))
                        {
                            outputFile.WriteLine(korisnickoImeTextBox.Text);
                        }
                        GlavnaForma gf = new GlavnaForma();
                            gf.Show();
                            this.Hide();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Niste popunili sve podatke!");
                }

                

            if (brojac == 3)
            {
                string tmpFile = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\tmp.txt";
                var lines = File.ReadAllLines(tmpFile);
                string ime = lines[1];

                string nazivCrt = ime + ".crt";

               // MessageBox.Show(nazivCrt);

                Functions.executeCommandReturn("/c " + "revokeCrt.sh " + nazivCrt);

                MessageBox.Show("Uneseni sertifikat je suspendovan!");
                string redniBrojListe = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\crlnumber")[0];

                Functions.executeCommandReturn("/c " + "generateCrl.sh " + redniBrojListe);


                OdlukaForma of = new OdlukaForma();
                of.Show();
                this.Hide();
            }

            
        }

        private void LogInForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            PocetnaForma pf = new PocetnaForma();
            pf.Show();
            this.Hide();
        }
    }
}
