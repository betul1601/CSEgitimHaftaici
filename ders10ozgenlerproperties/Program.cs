namespace Ders10Ozgenlerproperties
{
     class Skorlar
    {
        private int skor;
        public int Skor //klasik property yapısı
        {
            get { return skor; }// get bloğu yukarıdaki skor değişkeninin değerini döndürür
            set { skor = value; }//set bloğu ise yukarıdaki skor değişkenine değer atamayı sağlar.

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Özgenler - properties!");
            Skorlar skorlar = new();
            skorlar.Skor = 5;// skorlar nesnesinin Skor özelliğine değer ata (set bloğu çalışır)

            Console.WriteLine("Skor değeri:" + skorlar.Skor);// skorlar nesnenisin Skor özelliğinin değerini oku ve ekrana yaz(get bloğu çalışır)

            Kisi Taha = new Kisi();
            Taha.DogumYeri = "istanbul";
            Taha.Maas = 4000;
            Taha.Yas = 15;

            Kisi Betul = new()
            {
                DogumYeri = "ankara",
                Maas = 5000,
                Yas = 25
            };


            Console.WriteLine("TAHANIN BİLGİLERİ:");
            Console.WriteLine($"Doğum yeri:{Taha.DogumYeri} - yaş:{Taha.Yas} - maas:{Taha.Maas}");

            Console.WriteLine("betülün bilgileri");
            Console.WriteLine($"doğum yeri:{Betul.DogumYeri}-yas:{Betul.Yas}-maas:{Betul.Maas}");


            user User = new();
            User.Email = "info@admin.co";
            User.Password = "123456";
            User.Name = "taha";
            User.Created = DateTime.Now;

            Console.WriteLine("EMAİL ADRESİNİZİ GİRİNİZ");
            var email= Console.ReadLine();

            User.Email = email;
            Console.WriteLine("şifrenizi girinzi");
            User.Password = Console.ReadLine();

            var giris = User.kullanicigirisi(User.Email, User.Password); //var variable yani değişken demektir ve
            //veri türünü kendisine atanan değere bakarak otomatik belirleyen değişken oluşturmamızı sağlar

            var sayi = 18;
            var fiyat = 18.58;
            object deger = 25;
            var Urunadı = "bardak";

            if(giris==true) //eğer giriş metodunun sonucu true ise
            {
                Console.WriteLine("giriş başarılı");
            }

            else
                Console.WriteLine("giriş başarısız");
        }
    }
}