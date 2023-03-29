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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            FillListBox();
            string prijavljeniKorisnik = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\trenutnoPrijavljeniKorisnik.txt")[0];
            gornjiText.Text += " " + prijavljeniKorisnik.ToString()+":";


        }


        public void FillListBox()
        {
            string korisnik = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\trenutnoPrijavljeniKorisnik.txt")[0];
            string dir = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + korisnik + "\\fajlovi";
            var list = Directory.GetDirectories(dir);

            for (int i = 0; i < list.Length; i++)
            {
                var components = list.ElementAt(i).Split('\\');
                listBox.Items.Add(components[components.Length-1]);
            }
        }

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            string trenutniFilePath = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\trenutnoPrijavljeniKorisnik.txt";
            if (File.Exists(trenutniFilePath))
            {
                try
                {
                    File.Delete(trenutniFilePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            PocetnaForma pf = new PocetnaForma();
            pf.Show();
            this.Hide();
        }

        private void odjavaButton_Click(object sender, EventArgs e)
        {
            string trenutniFilePath = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\trenutnoPrijavljeniKorisnik.txt";
            if (File.Exists(trenutniFilePath))
            {
                try
                {
                    File.Delete(trenutniFilePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            PocetnaForma pf = new PocetnaForma();
            pf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DodavanjaFajlaForm df = new DodavanjaFajlaForm();
            df.Show();
            this.Hide();
            
        }

        private void preuzimanjeFajlaButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali ni jedan fajl!");
            }

            else
            {
                //da li vec postoji fajl
                string korisnik = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\trenutnoPrijavljeniKorisnik.txt")[0];
                string dir = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Downloads";
                var list = Directory.GetFiles(dir);

                

                string nazivFajla = listBox.GetItemText(listBox.SelectedItem);
                string nazivFajlaa = listBox.GetItemText(listBox.SelectedItem);
                string samoIme = nazivFajla.Split('.')[0];

                


                bool postoji = false;

                string nazivTrazenog = "";
                int brojac = 0;

                for (int i = 0; i < list.Length; i++)
                {
                    var components = list.ElementAt(i).Split('\\');
                    string nazivJednogOdFajlova = (components[components.Length - 1]);
                    if (nazivJednogOdFajlova.StartsWith(samoIme))
                    {
                        postoji = true;
                        brojac+=1;
                       // MessageBox.Show(nazivJednogOdFajlova + brojac.ToString());
                    }
                }

                if (postoji)
                {
                   // MessageBox.Show(brojac.ToString());
                    nazivFajlaa = samoIme + "("+brojac+").txt";
                    
                }
                
                string trenutnoPrijavljeniKorisnik = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\trenutnoPrijavljeniKorisnik.txt")[0];
                string nazivDirektorijumaUKojemSuSegmentiFajla = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla;
                var segmenti = Directory.GetDirectories(nazivDirektorijumaUKojemSuSegmentiFajla);

                string encAlg = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO\\" + trenutnoPrijavljeniKorisnik + ".txt")[3];
                string hashSelected = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\INFO\\" + trenutnoPrijavljeniKorisnik + ".txt")[2];
                //string privatniKljuc = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\" + trenutnoPrijavljeniKorisnik + ".key";
                string javniKljuc = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\" + trenutnoPrijavljeniKorisnik + "-public.key";
                bool fajlNijePromijenjen = true;
                string key = "";

                //dobijanje kljuca za dekripciju
                Functions.executeCommandReturn("/c " + "getKey.sh " + trenutnoPrijavljeniKorisnik + " " + nazivFajla);

                key = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\keyDec.txt")[0];


                for (int i = 1; i <= segmenti.Length; i++)
                {
                    string putdoItogSegmenta = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\" + i;
                    string hash = "";


                    if (hashSelected.Equals("MD5"))
                    {
                        hash = "md5";
                    }
                    else if (hashSelected.Equals("SHA-512"))
                    {
                        hash = "sha512";
                    }
                    else
                    {
                        hash = "sha256";
                    }
                    string potpis = putdoItogSegmenta + "//potpis" + i + ".txt";
                    string fajlZaProvjeru = putdoItogSegmenta + "//" + i + ".txt";
                    string tmpFile = putdoItogSegmenta + "//tmp.txt";

                    


                    Functions.executeCommandReturn("/c " + "getDecryptedFile.sh " + encAlg + " " + fajlZaProvjeru + " " + tmpFile + " " + key);

                    String command = "/c openssl dgst -" + hash + " -prverify Users/" + trenutnoPrijavljeniKorisnik + "/" + trenutnoPrijavljeniKorisnik + ".key -signature " + potpis + " " + tmpFile;
                    String response = Functions.executeCommandReturn(command).Trim();




                    /* if (hashSelected.Equals("MD5"))
                          Functions.executeCommandReturn("/c " + "verifikacijaPotpisa.sh " + "-md5" + " " + trenutnoPrijavljeniKorisnik + " " + i+" "+nazivFajla);
                     else if (hashSelected.Equals("SHA-512"))
                         Functions.executeCommandReturn("/c " + "verifikacijaPotpisa.sh " + "-sha512" + " " + trenutnoPrijavljeniKorisnik + " " + i + " " + nazivFajla);
                     else
                          Functions.executeCommandReturn("/c " + "verifikacijaPotpisa.sh " + "-sha256" + " " + trenutnoPrijavljeniKorisnik + " " + i + " " + nazivFajla);

                     string response = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\" + i + "\\response.txt")[0];
                    */

                    if (response.Equals("Verified OK"))
                    {
                        //MessageBox.Show(i + " segment je OK");
                        if (File.Exists("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\" + i + "\\response.txt"))
                        {
                            try
                            {
                                File.Delete(("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\" + i + "\\response.txt"));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        if (File.Exists("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\keyDec.txt"))
                        {
                            try
                            {
                                File.Delete(("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\keyDec.txt"));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        MessageBox.Show("Fajl nije moguće preuzeti jer je segment " + i + " izmjenjen");
                        if (File.Exists("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\" + i + "\\response.txt"))
                        {
                            try
                            {
                                File.Delete(("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\" + i + "\\response.txt"));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        fajlNijePromijenjen = false;
                        if (File.Exists(tmpFile))
                        {
                            try
                            {
                                File.Delete((tmpFile));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        //string keyDec = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\katarina\\fajlovi\\" + nazivFajla + "\\keyDec.txt";
                        

                        break;
                    }

                    if (File.Exists(tmpFile))
                    {
                        try
                        {
                            File.Delete((tmpFile));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                }

                /*string keyDec = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\katarina\\fajlovi\\" + nazivFajla + "\\keyDec.txt";
                if (File.Exists(keyDec))
                {
                    try
                    {
                        File.Delete((keyDec));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }*/

                if (fajlNijePromijenjen) //kreiranje fajla u Downloads folderu :)
                {
                    string path = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Downloads";
                    for (int i = 1; i <= segmenti.Length; i++)
                    {
                        string putdoItogSegmenta = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\" + i;
                        string fajlZaDekripciju = putdoItogSegmenta + "//" + i + ".txt";
                        string putDoTmp = putdoItogSegmenta + "//tmp.txt";


                        Functions.executeCommandReturn("/c " + "getDecryptedFile.sh " + encAlg + " " + fajlZaDekripciju + " "+putDoTmp+" " + key);
                        var linijeDekriptovanogFajla = File.ReadAllLines(putDoTmp);
                        bool manjeOdCetiriLinijeFajla = false;

                        string textManjeOdCetiri = "";
                        
                        for (int j = 0; j < linijeDekriptovanogFajla.Length; j++)
                        {

                            if (j == 0)
                            {
                                try
                                {
                                    if (linijeDekriptovanogFajla[j].ElementAt(0).Equals('`'))
                                    {
                                        manjeOdCetiriLinijeFajla = true;
                                    }
                                }catch(Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }

                            if (manjeOdCetiriLinijeFajla) //****
                            {
                                if (j == 0)
                                {
                                    string s = linijeDekriptovanogFajla[j].Replace("`", "");

                                    if(s.Contains("\n") && s.EndsWith("\n"))
                                    {
                                        textManjeOdCetiri += s.Replace("\n", "");
                                    }
                                    else
                                    {
                                        textManjeOdCetiri += s;
                                    }
                                    /*using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, nazivFajlaa), true))
                                    {
                                        outputFile.Write(s);
                                    }*/
                                }
                                else
                                {
                                    string s = "";
                                    if(linijeDekriptovanogFajla[j].StartsWith("\n"))
                                    {
                                        s = linijeDekriptovanogFajla[j].Replace("\n", "");
                                        textManjeOdCetiri += s;
                                    }
                                    /*else if(!linijeDekriptovanogFajla[j].ElementAt(linijeDekriptovanogFajla.Length - 1).Equals("\n") && linijeDekriptovanogFajla[j].Contains("\n"))
                                    {
                                        s = linijeDekriptovanogFajla[j].Replace("\n", "");
                                    }*/
                                    else if(!linijeDekriptovanogFajla[j].EndsWith("\n") && linijeDekriptovanogFajla[j].Contains("\n"))
                                    {
                                        s = linijeDekriptovanogFajla[j].Replace("\n", "");
                                        textManjeOdCetiri += s;
                                    }

                                    /*using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, nazivFajlaa), true))
                                    {
                                        outputFile.Write(s);


                                    }*/
                                }
                                using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, nazivFajlaa), true))
                                {
                                    outputFile.Write(textManjeOdCetiri);
                                }

                            } //********************
                            else //vise od 4 linije
                            {
                                using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, nazivFajlaa), true))
                                {
                                    outputFile.WriteLine(linijeDekriptovanogFajla[j]);


                                }
                            }
                            
                        }



                        if (File.Exists(putDoTmp))
                        {
                            try
                            {
                                File.Delete((putDoTmp));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

                       
                    }
                    if (File.Exists("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\keyDec.txt"))
                    {
                        try
                        {
                            File.Delete(("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\Users\\" + trenutnoPrijavljeniKorisnik + "\\fajlovi\\" + nazivFajla + "\\keyDec.txt"));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    MessageBox.Show("Fajl " + nazivFajlaa + " je uspješno preuzet!");
                }

            }
        }
    }
}
