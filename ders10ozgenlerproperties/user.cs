using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10Ozgenlerproperties
{
    internal class user
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }   
        public string Email { get; set; }   
        public string PhoneNumber { get; set; } 
        public DateTime Created { get; set; }

        public bool kullanicigirisi(string Mail, string Sifre)
        {
            string veritabanindakimail = "info@admin.co";
            string veritabanindakisifre = "123456";
            bool islemsonucu=false; 


            if(Mail==veritabanindakimail & Sifre==veritabanindakisifre)
            {
                islemsonucu=true;   //eğer gönderilen değerler eşleşirse islemsonucu değerini true yap
            }
            return islemsonucu;
        }

    }
    
}
