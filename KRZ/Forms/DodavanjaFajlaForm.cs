
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
{//napraviti jos kada dodajemo iste fajlove (1),(2),(3)...

    //dekodovanje -d -base64 
    public partial class DodavanjaFajlaForm : Form
    {
        string nazivFajla = "";
        public DodavanjaFajlaForm()
        {
            InitializeComponent();
        }

        private void odabirFajlaButton_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName.ToString();
                    var components = path.Split('\\');
                    string newPath = "";
                    int i = 0;
                    foreach (var x in components)
                    {
                        if (i == 0)
                        {
                            newPath += x;
                            i = 5;
                        }
                        else
                        {
                            newPath += "\\\\" + x;
                        }
                    }
                    //naziv fajla
                    nazivFajla = components[components.Length - 1];

                    bool nedovoljnoKaraktera = false;

                    if (!newPath.EndsWith(".txt"))
                    {
                        MessageBox.Show("Morate odabrati tekstualni fajl!");
                    }
                    else
                    {
                        //imamo putanju do zeljenog fajla
                        Random rand = new Random();
                        int randomNumber = rand.Next(4, 10);

                        string kompletanText = "";
                        int brojRedovaFajla = 0;

                        var lines = File.ReadAllLines(newPath);
                        brojRedovaFajla = lines.Length;

                        

                        if (brojRedovaFajla < 4)
                        {
                            if (brojRedovaFajla == 1 && lines[0].Length < 4)
                            {
                                nedovoljnoKaraktera = true;
                            }

                            if (!nedovoljnoKaraktera)
                            {
                                foreach (string s in lines)
                                {
                                    kompletanText += s + '\n';
                                }
                            }

                        }


                        //kreiranje foldera sa imenom fajla koji dodajemo
                        string prijavljeniKorisnik = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\trenutnoPrijavljeniKorisnik.txt")[0];
                        string encAlg = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO\\" + prijavljeniKorisnik + ".txt")[3];
                        string hashSelected = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO\\" + prijavljeniKorisnik + ".txt")[2];
                        string privatniKljuc = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + prijavljeniKorisnik + "\\" + prijavljeniKorisnik + ".key";
                        string javniKljuc = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + prijavljeniKorisnik + "\\" + prijavljeniKorisnik + "-public.key";

                        string odredisniFolder = "";
                        if (Directory.Exists("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + prijavljeniKorisnik + "\\fajlovi\\" + nazivFajla))
                        {
                            MessageBox.Show("Fajl naziva " + nazivFajla + " postoji!");
                        }
                        else
                        {
                            odredisniFolder = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + prijavljeniKorisnik + "\\fajlovi\\" + nazivFajla;
                            //DirectoryInfo di = Directory.CreateDirectory(odredisniFolder);


                            string tmpFile = "tmp.txt";

                            if (nedovoljnoKaraktera)
                            {
                                MessageBox.Show("Fajl mora da sadrži bar 4 karaktera!");
                            }

                            else if (brojRedovaFajla < 4)
                            {
                                //MessageBox.Show("Broj redova fajla mora biti veci od 4");
                                while (randomNumber > (kompletanText.Length - brojRedovaFajla))
                                {
                                    randomNumber = rand.Next(4, 15);
                                }

                                int brojFajlovaNaKojiRazdvajamo = randomNumber;
                                int brojKarakteraZaSvakiFajl = kompletanText.Length / randomNumber;
                                int ostatak = kompletanText.Length - (brojKarakteraZaSvakiFajl * randomNumber);



                                int brojac = 0;
                                var finalString = "";
                                for (int j = 0; j < brojFajlovaNaKojiRazdvajamo; j++)
                                {
                                    string naziv = (j + 1) + ".txt";

                                    //kreiranje direktorijuma za svaki fajl
                                    DirectoryInfo dir = Directory.CreateDirectory(odredisniFolder + "\\" + (j + 1));
                                    string dirr = odredisniFolder + "\\" + (j + 1);

                                    
                                    if (j == 0)
                                    {
                                        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                                        var pass = new char[14];
                                        var random = new Random();

                                        for (int s = 0; s < pass.Length; s++)
                                        {
                                            pass[s] = chars[random.Next(chars.Length)];
                                        }

                                        finalString = new String(pass);
                                        //MessageBox.Show(finalString);

                                        using (StreamWriter outputFilee = new StreamWriter(Path.Combine(odredisniFolder, "keyTmp.txt"), true))
                                        {
                                            outputFilee.Write(finalString);
                                        }

                                        //** kreiranje dig envelope
                                        Functions.executeCommandReturn("/c " + "generateDigitalSignature.sh " + prijavljeniKorisnik + " " + nazivFajla);
                                        if (File.Exists(odredisniFolder + "\\keyTmp.txt"))
                                        {
                                            try
                                            {
                                                File.Delete(odredisniFolder + "\\keyTmp.txt");
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }
                                        }

                                        //**************
                                    }


                                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(dirr, tmpFile), true))
                                    {
                                        if (j == 0)
                                        {
                                            string s = '`' + kompletanText.Substring(brojac, brojKarakteraZaSvakiFajl);
                                            outputFile.Write(s);
                                        }
                                        else
                                        {
                                            outputFile.Write(kompletanText.Substring(brojac, brojKarakteraZaSvakiFajl));
                                        }
                                        brojac += brojKarakteraZaSvakiFajl;

                                    }

                                    if (j == brojFajlovaNaKojiRazdvajamo - 1)
                                    {
                                        using (StreamWriter outputFile = new StreamWriter(Path.Combine(dirr, tmpFile), true))
                                        {
                                            outputFile.Write(kompletanText.Substring(brojac, ostatak));
                                            brojac = brojKarakteraZaSvakiFajl;

                                        }
                                    }

                                    if (hashSelected.Equals("MD5"))
                                        Functions.executeCommandReturn("/c " + "generateSignature.sh " + "-md5" + " " + prijavljeniKorisnik + " " + nazivFajla + " " + (j + 1) + " " + (dirr + "\\tmp.txt"));
                                    else if (hashSelected.Equals("SHA-512"))
                                        Functions.executeCommandReturn("/c " + "generateSignature.sh " + "-sha512" + " " + prijavljeniKorisnik + " " + nazivFajla + " " + (j + 1) + " " + (dirr + "\\tmp.txt"));
                                    else
                                        Functions.executeCommandReturn("/c " + "generateSignature.sh " + "-sha256" + " " + prijavljeniKorisnik + " " + nazivFajla + " " + (j + 1) + " " + (dirr + "\\tmp.txt"));


                                    Functions.executeCommandReturn("/c " + "generateEncryptedFile.sh " + encAlg + " " + prijavljeniKorisnik + " " + nazivFajla + " " + (j + 1) + " " + finalString);

                                    if (File.Exists(dirr + "\\" + tmpFile))
                                    {
                                        try
                                        {
                                            File.Delete(dirr + "\\" + tmpFile);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }

                                }
                                MessageBox.Show("Fajl je uspješno dodat!");
                                this.Hide();
                                GlavnaForma gf = new GlavnaForma();
                                gf.Show();
                            }
                            else if (brojRedovaFajla >= 4)
                            {

                                

                                while (randomNumber > brojRedovaFajla)
                                {
                                    randomNumber = rand.Next(4, 15);
                                }

                                int brojFajlovaNaKojiRazdvajamo = randomNumber;
                                int brojRedovaZaSvakiFajl = brojRedovaFajla / brojFajlovaNaKojiRazdvajamo;
                                int ostatak = brojRedovaFajla - (brojRedovaZaSvakiFajl * brojFajlovaNaKojiRazdvajamo);
                                int brojac = 0;

                                var finalString = "";
                                for (int m = 0; m < brojFajlovaNaKojiRazdvajamo; m++)
                                {

                                    //kreiranje direktorijuma za svaki fajl
                                    DirectoryInfo dir = Directory.CreateDirectory(odredisniFolder + "\\" + (m + 1));

                                    //****
                                    
                                    if (m == 0)
                                    {
                                        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                                        var pass = new char[14];
                                        var random = new Random();

                                        for (int s = 0; s < pass.Length; s++)
                                        {
                                            pass[s] = chars[random.Next(chars.Length)];
                                        }

                                        finalString = new String(pass);
                                        //MessageBox.Show(finalString);

                                        using (StreamWriter outputFilee = new StreamWriter(Path.Combine(odredisniFolder, "keyTmp.txt"), true))
                                        {
                                            outputFilee.Write(finalString);
                                        }

                                        //** kreiranje dig envelope
                                        Functions.executeCommandReturn("/c " + "generateDigitalSignature.sh " + prijavljeniKorisnik + " " + nazivFajla);
                                        if (File.Exists(odredisniFolder + "\\keyTmp.txt"))
                                        {
                                            try
                                            {
                                                File.Delete(odredisniFolder + "\\keyTmp.txt");
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }
                                        }

                                        //**************
                                    }

                                    string dirr = odredisniFolder + "\\" + (m + 1);

                                    string naziv = (m + 1) + ".txt";

                                    StreamWriter outputFile = new StreamWriter(Path.Combine(dirr, tmpFile), true);
                                    for (int n = 0; n < brojRedovaZaSvakiFajl; n++)
                                    {
                                        outputFile.WriteLine(lines[brojac]);

                                        brojac++;
                                    }
                                    outputFile.Close();

                                    outputFile = new StreamWriter(Path.Combine(dirr, tmpFile), true);
                                    if ((m == (brojFajlovaNaKojiRazdvajamo - 1)) && brojac < lines.Length)
                                    {
                                        while (brojac < lines.Length)
                                        {

                                            outputFile.WriteLine(lines[brojac]);

                                            brojac++;
                                        }
                                    }
                                    outputFile.Close();


                                    // MessageBox.Show("segment "+(m + 1).ToString());

                                    //MessageBox.Show("segment " + (m + 1).ToString()+" kriptovan");
                                    if (hashSelected.Equals("MD5"))
                                        Functions.executeCommandReturn("/c " + "generateSignature.sh " + "-md5" + " " + prijavljeniKorisnik + " " + nazivFajla + " " + (m + 1) + " " + (dirr + "\\tmp.txt"));
                                    else if (hashSelected.Equals("SHA-512"))
                                        Functions.executeCommandReturn("/c " + "generateSignature.sh " + "-sha512" + " " + prijavljeniKorisnik + " " + nazivFajla + " " + (m + 1) + " " + (dirr + "\\tmp.txt"));
                                    else
                                        Functions.executeCommandReturn("/c " + "generateSignature.sh " + "-sha256" + " " + prijavljeniKorisnik + " " + nazivFajla + " " + (m + 1) + " " + (dirr + "\\tmp.txt"));

                                    Functions.executeCommandReturn("/c openssl " + encAlg + " -base64 -in Users/" + prijavljeniKorisnik + "/fajlovi/" + nazivFajla + "/" + (m + 1) + "/tmp.txt -out Users/" + prijavljeniKorisnik + "/fajlovi/" + nazivFajla + "/" + (m + 1) + "/" + (m + 1) + ".txt -k " + finalString);


                                    if (File.Exists(dirr + "\\" + tmpFile))
                                    {
                                        try
                                        {
                                            File.Delete(dirr + "\\" + tmpFile);
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }


                                }
                                MessageBox.Show("Fajl je uspješno dodat!");
                                this.Hide();
                                GlavnaForma gf = new GlavnaForma();
                                gf.Show();
                            }

                        }




                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void DodavanjaFajlaForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            GlavnaForma gf = new GlavnaForma();
            gf.Show();
        }
    }


}
