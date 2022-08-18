using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08Classlar
{
    internal class urun
    {
        public int Id;
        public string urunadi;
        public int stok;
        public decimal fiyat;
        public string ozellikler;
        public kategori Kategori; //urun classı ile kategori classı arasındaki bağlantı
        public int KategoriId;


    }
}
