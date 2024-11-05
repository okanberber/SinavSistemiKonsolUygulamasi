using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region overload string     
            Sinav deneme = new Sinav();
            deneme.isim = "Deneme Sınavı";
            deneme.gecmePuani = 70;
            deneme.tur = "Fizik";

            deneme.SoruEkle("Suyun kaynama sıcaklığı nedir ?", "90", "80", "-20", "100", "D"); // parametreleri değişkenlere gönderdik
            #endregion


            #region overload sınıf
            Soru soru = new Soru();
            soru.metin = "overload nedir";                      
            soru.secenekA = "yemektir";
            soru.secenekB = "dürümdür";
            soru.secenekC = "metotların aşırı yüklenmesidir";
            soru.secenekD = "ne bilim ben";
            soru.dogru = "c";

            deneme.SoruEkle(soru);      // parametreleri sınıf olarak gönderdik

            int toplam = 0;
            for (int i = 0; i < deneme.sorular.Length; i++)
            {
                Console.Clear();
                deneme.SoruYazdir(i);
                Console.WriteLine("Cevap Seçiniz");
                string cevap = Console.ReadLine();

                if(cevap == deneme.DogruCevap(i))
                {
                    toplam += 20;
                }
            }
            Console.WriteLine("Sınav tamamlandı");
            Console.WriteLine("Puanınız" + toplam);
            #endregion

        }
    }
}
