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
    public partial class OdlukaForma : Form
    {
        public OdlukaForma()
        {
            InitializeComponent();
        }

        private void buttonNoviNalog_Click(object sender, EventArgs e)
        {
            SignUpForma suf = new SignUpForma();
            suf.Show();
            this.Hide();
        }

        private void buttonSertifikat_Click(object sender, EventArgs e)
        {

            if (!tbKorisnickoIme.Text.Equals("") && !tbLozinka.Text.Equals(""))
            {


                string tmpFile = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\tmp.txt";
                var lines = File.ReadAllLines(tmpFile);

                string t = lines[0].Split(':')[1];
                var tts = t.Split('\\'); // Users, AcerAspireE5, ...

                string trazenoKorisnickoIme = tts[tts.Length - 1].Split('.')[0]; //kaca

                string filePath = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO\\" + trazenoKorisnickoIme + ".txt";
                var list = File.ReadAllLines(filePath);
                string command = "";
                if (list[2].Equals("MD5"))
                    command = "/c openssl passwd -1 -salt 12345678 " + tbLozinka.Text;
                else if (list[2].Equals("SHA-512"))
                    command = "/c openssl passwd -6 -salt 12345678 " + tbLozinka.Text;
                else
                    command = "/c openssl passwd -5 -salt 12345678 " + tbLozinka.Text;
                String passHash = (Functions.executeCommandReturn(command)).Trim();
                var passExists = passHash.Equals(list[1]);

                if (!trazenoKorisnickoIme.Equals(tbKorisnickoIme.Text) || !passExists)
                {
                    MessageBox.Show("Nisu unijeti ispravni kredencijali! Sertifikat ostaje suspendovan!");
                    PocetnaForma pf = new PocetnaForma();
                    pf.Show();
                    this.Hide();
                }


                else
                {
                    string serijskiBroj = "";

                    string nazivSertifikata = lines[1] + ".crt";
                   // MessageBox.Show(nazivSertifikata);
                    Functions.executeCommandReturn("/c " + "generateSerialNumber.sh " + nazivSertifikata);
                    string sfile = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\serial.txt";

                    serijskiBroj = File.ReadAllLines(sfile)[0].Split('=')[1];


                    string indexFile = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\index.txt";
                    var indexLines = File.ReadAllLines(indexFile);
                    List<String> redoviFajla = new List<string>();
                    foreach (string s in indexLines)
                    {
                        if (s.StartsWith("V"))
                        {
                            redoviFajla.Add(s);
                        }
                        
                        if (s.StartsWith("R") )
                        {
                                var tmp = s.Replace('\t', ' ');
                                var lala = tmp.Split(' ');
                            if (lala[3].Equals(serijskiBroj))
                            {
                                string zamjenski = "V" + '\t' + lala[1] + '\t' + '\t' + lala[3] + '\t' + lala[4] + ' ' + lala[5] + ' ' + lala[6];
                                redoviFajla.Add(zamjenski);
                            }
                            else
                            {
                                redoviFajla.Add(s);
                            }

                        }
                        
                    }

                    if (File.Exists(indexFile))
                    {
                        try
                        {
                            File.Delete(indexFile);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    
                    if (File.Exists(sfile))
                    {
                        try
                        {
                            File.Delete(sfile);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
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



                    foreach (string ss in redoviFajla)
                    {
                        using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ", "index.txt"), true))
                        { 
                            outputFile.WriteLine(ss);
                        }
                    }

                    MessageBox.Show("Sertifikat je aktiviran!");
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ", "trenutnoPrijavljeniKorisnik.txt"), true))
                    {
                        outputFile.WriteLine(tbKorisnickoIme.Text);
                    }
                    GlavnaForma gf = new GlavnaForma();
                    gf.Show();
                    this.Hide();
                }

            }

        }

        private void OdlukaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            PocetnaForma pf = new PocetnaForma();
            pf.Show();
            this.Hide();
        }
    }


}
