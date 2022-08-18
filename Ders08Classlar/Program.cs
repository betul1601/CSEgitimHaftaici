// See https://aka.ms/new-console-template for more information

//using Ders08Classlar;
public class Ev // C# ta class tanımlama
{
    public int KapiNo; // Sınıf değişkenleri oluşturma
    public string SokakAdi;
}

namespace Ders08Classlar
   // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar-Classes!");

            // 1. Yöntem
            Ev ev = new(); // ev sınıfından bir nesne oluşturduk

            ev.KapiNo = 1; // ev nesnesinin değişkenlerine değer atadık
            ev.SokakAdi = "Okul sokak";

            Console.WriteLine("Ev adresimiz : " + ev.SokakAdi + " sk. No :" + ev.KapiNo); // ev nesnesinin özelliklerini ekrana yazdırdık

            //2. Yöntem
            Ev yazlik = new()
            {
                SokakAdi = "Yalı kavak sokak",
                KapiNo = 18
            };

            Console.WriteLine($"Yazlık adresi : {yazlik.SokakAdi} sk. No:{yazlik.KapiNo} Bodrum/Muğla");

            Kurs kurs = new()
            {
                KursAdi = "Arı Bilgi",
                EgitimAdi = "Yazılım Uzmanlığı",
                KapiNo = 102,
                SinifMevcudu = 6
            };

            Console.WriteLine("Kurs Bilgilerim \n : Kurs Adı {0} Eğitim Adı : {1} Kapı No : {2}", kurs.KursAdi, kurs.EgitimAdi, kurs.KapiNo);

            Araba araba = new()
            {
                kasatipi = "sedan",
                marka = "fiat",
                model="linea",
                renk = "beyaz",
                Uretimyili = 2013
            };
            Console.WriteLine($" araba bilgileriniz:\n marka:{araba.marka} \n model:{araba.model}\n renk:{araba.renk} \n uretimyili :{araba.Uretimyili}");

            urun urun = new()
            {
                fiyat = 99,
                ozellikler = "ışıklı klavye",
                stok = 18,
                urunadi = "oyuncu klavye"

            };
            Console.WriteLine("ürün bilgileri");
            Console.WriteLine($"ürün adı:{urun.urunadi}");
            Console.WriteLine($"ürün fiyatı:{urun.fiyat}");
            Console.WriteLine($"ürün stok:{urun.stok}");
            Console.WriteLine($"ürün özellikler:{urun.ozellikler}");

            Console.WriteLine();
            Console.WriteLine("sınıfta metot kullanımı");
            Siniftametodkullanimi sınıftametodkullanimi = new();
            sınıftametodkullanimi.ToplamaYap();
            //Console.WriteLine(sınıftametodkullanimi.mesaj);
            //static olarak belirtilmeyen metot ve değişkenler dinamiktir.
            //sınıfların içindeik dinamik metot vedeğişkenlere ulaşmak için yukarıdaki gibi new leyerek nesne oluşturmamız gerekir.
            Siniftametodkullanimi.statictoplamayap(18,18); // static metoda direk classadı.metot diyerek ulaşabilirz, nesneye (sınıftametodkullanimi) ihtiyscımız yok
            Console.WriteLine(Siniftametodkullanimi.statikdeğişken);
            //ctrl kd sayfayı düzene sokar

        }
    }
}

public class Kurs
{
    public int KapiNo;
    public string KursAdi;
    public string EgitimAdi;
    public int SinifMevcudu;
}

public class Araba
{
    public string marka;
    public string model;
    public string renk;
    public string kasatipi;
    public int Uretimyili;
}
