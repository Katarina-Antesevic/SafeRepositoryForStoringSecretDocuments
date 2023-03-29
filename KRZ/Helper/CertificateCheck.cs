using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRZ
{
    class CertificateCheck
    {
        public static bool isCertificateValidDate(string certificate)
        {

            bool rjes = true;
            Functions.executeCommandReturn("/c " + "getDatesFromCertificate.sh " + certificate);
            string cert = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\cert.txt";
            var lines = File.ReadAllLines(cert);
            
            var myLine = lines[1].Replace("  ", " ");
            string month = myLine.Split('=')[1].Split(' ')[0];
            string day = myLine.Split('=')[1].Split(' ')[1];
            string year = myLine.Split('=')[1].Split(' ')[3];
            string mm;
            if (month == "Jan")
            {
                mm = "01";
            }
            else if (month == "Feb")
            {
                mm = "02";
            }
            else if (month == "Mar")
            {
                mm = "03";
            }
            else if (month == "Apr")
            {
                mm = "04";
            }
            else if (month == "May")
            {
                mm = "05";
            }
            else if (month == "Jun")
            {
                mm = "06";
            }
            else if (month == "Jul")
            {
                mm = "07";
            }
            else if (month == "Aug")
            {
                mm = "08";
            }
            else if (month == "Sep")
            {
                mm = "09";
            }
            else if (month == "Oct")
            {
                mm = "10";
            }
            else if (month == "Nov")
            {
                mm = "11";
            }
            else
            {
                mm = "12";
            }

            var nn = new DateTime();
            string todayYear = DateTime.Now.ToString("yyyy");
            string todayMonth = (DateTime.Now).ToString("mm");
            string todayDay = DateTime.Now.ToString("dd");

            if (int.Parse(todayYear) > int.Parse(year))
            {
                rjes = false;
            }
            if((int.Parse(todayYear) == int.Parse(year)) && (int.Parse(todayMonth) < int.Parse(mm)))
            {
                rjes = false;
            }

            if ((int.Parse(todayYear) == int.Parse(year)) && (int.Parse(todayMonth) == int.Parse(mm)) && (int.Parse(todayDay) < int.Parse(day)))
            {
                rjes = false;
            }


            File.Delete(cert);
            return rjes;
           
        }

        public static bool isCertificateValidCrl(string certificate)
        {
            Functions.executeCommandReturn("/c " + "openssl x509 -in " + certificate+ " -serial -noout > serialNumber.txt");
            string cert = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\serialNumber.txt";
            var lines = File.ReadAllLines(cert);
            
            string serial = lines[0].Split('=')[1]; //npr 05
            var allCertificates = File.ReadAllLines("C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ\\index.txt");
            List<string> revokedCertificates = new List<string>();
            foreach (var x in allCertificates)
            {
                if (x.StartsWith("R"))
                    revokedCertificates.Add(x);
            }

            foreach (var x in revokedCertificates)
            {
                if (serial.Equals(x.Split('\t')[3]))
                {
                    File.Delete(cert);
                    return false;
                }
                    
            }
            File.Delete(cert);
            return true;
        }

    }
}
