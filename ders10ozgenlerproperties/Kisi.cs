using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10Ozgenlerproperties
{
    internal class Kisi
    {
        private int yas;
        private string dogumyeri;
        string meslek;
        double maas;
        public double Maas
        {
            get { return maas; }
            set
            {
                if (value <= 4250)
                {
                    maas = 4250;
                }
                else maas = value;
            }
        }

        public int Yas
        {
            get { return yas; }

            set
            {
                if (value<=65 && value>=18) yas = value;
                else yas = 18;

            }

        }
            public string DogumYeri
        {
            get { return dogumyeri; }
            set { dogumyeri = value; }
        }
    }
}
