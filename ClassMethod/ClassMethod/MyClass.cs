using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public struct Ogrenci
    {
        public string ogrenciNo { get; set; }
        public string vize { get; set; }
        public string odev { get; set; }
        public string final { get; set; }
        public string harfNotu { get; set; }
        public string ortalama { get; set; }

        public Ogrenci(string ogrenciNo, string vize, string odev, string final,string harfNotu)
        {
            this.ogrenciNo = ogrenciNo;
            this.vize = vize;
            this.final = final;
            this.odev = odev;
            this.harfNotu = harfNotu;
            this.ortalama = (double.Parse(vize)* 30 / 100 + double.Parse(odev) * 30 / 100 + double.Parse(final) * 40 / 100).ToString();
        }

    }
    class MyClass
    {
        List<Ogrenci> Ogrenciler;
        public List<Ogrenci> OgrenciOku(string yol)
        {
            Ogrenciler = new List<Ogrenci>();
            StreamReader sr = new StreamReader(yol);
            var metin = sr.ReadToEnd();
            var satirlar = metin.Split("\r\n".ToCharArray());
            foreach (var satir in satirlar)
            {
                if (string.IsNullOrEmpty(satir)) continue;
                var hucreler = satir.Split();
                Ogrenciler.Add(new Ogrenci(hucreler[0], hucreler[1], hucreler[2], hucreler[3],null));
            }
            return Ogrenciler;
        }
        public List<Ogrenci> guncelle(int cc, int dagilim)
        {

            for (int i = 0; i < Ogrenciler.Count; i++)
            {
                Ogrenci ogrenci = Ogrenciler[i];
                double ort = double.Parse(ogrenci.ortalama);
                if (ort > (cc + 4 * dagilim))
                    ogrenci.harfNotu = "AA";
                else if (ort > (cc + 3 * dagilim))
                    ogrenci.harfNotu = "BA";
                else if (ort > (cc + 2 * dagilim))
                    ogrenci.harfNotu = "BB";
                else if (ort > (cc + dagilim))
                    ogrenci.harfNotu = "CB";
                else if (ort > cc)
                    ogrenci.harfNotu = "CC";
                else if (ort > (cc - dagilim))
                    ogrenci.harfNotu = "DC";
                else if (ort > (cc - 2 * dagilim))
                    ogrenci.harfNotu = "DD";
                else
                    ogrenci.harfNotu = "FF";
                Ogrenciler[i] = ogrenci;
            }

            return Ogrenciler;
        }
    }
}
