using System;
using System.Collections.Generic;
using System.Text;

namespace Sınıf_Class__Nedir
{
    class kisiler
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public void Yazdir()
        {
            Console.WriteLine("{0} {1} adlı kişi {2} yaşında dır.", Ad, Soyad, Yas);
        }
    }
}
