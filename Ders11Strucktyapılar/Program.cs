namespace Ders11Structyapılar
{

    struct Yapi
    {
         internal string ad;
         
        //int sayi = 5; // structlarda değişkenlere başlangıç değeri atanmaz
        internal static int sayi = 5; // başlangıç değeri atamamız gerekirse static tanımlamalıyız! 
        public string metin;
         internal void StructMetot()
        {
            Console.WriteLine("struct içerisinde metot kullanımı");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct-yapılar");
            Yapi yapi = new();
            yapi.metin = "struct içindeki metin değişkeni";
            yapi.ad = "taha";
            Console.WriteLine(yapi.metin);
            Console.WriteLine("isim:" + yapi.ad);
            yapi.StructMetot();//struct içindeki metot

        }       
    }
}