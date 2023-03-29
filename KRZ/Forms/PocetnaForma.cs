using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRZ
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //kreirajte nalog Dugme
        {
            SignUpForma forma = new SignUpForma();
            forma.Show();
            this.Hide();
            
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            DigitalniSertifikatForma dsforma = new DigitalniSertifikatForma();
            dsforma.Show();
            this.Hide();
        }

        private void PocetnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                Application.Exit();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
