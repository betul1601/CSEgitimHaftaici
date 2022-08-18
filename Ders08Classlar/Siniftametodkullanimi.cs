using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08Classlar
{
    public class Siniftametodkullanimi
    {
        public string mesaj = "";
        public Siniftametodkullanimi()//klavyeden ctor yazıp 2 kere tab a basarak oluşturduk
        {
            //burası constructor(yapıcı-kurucu) metot: kurucu metotlar class lar new lendiği anda çalışan metotlardır. böylece bir classtan nesne oluştuğu anda bir işlem yapmamızı sağlar
            mesaj = "kurucu metot çalıştı";
            Console.WriteLine(mesaj);
        }

        public void ToplamaYap()  //CLASS LAR içerisinde metotalr tanımlayabiliriz böylce tekrar eden kodları toparlayıp kod tekrarını engelleyebiliriz
        {
            Console.WriteLine(10 + 8);
        }
        public static void statictoplamayap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);  //parametreden gönderilecek sayıları topla ve sonucu ekrana yazdır
        }
        public static string statikdeğişken = "statik değişkenlere sınıfadı. diyerek ulaşabilirz";
        
    }
}
