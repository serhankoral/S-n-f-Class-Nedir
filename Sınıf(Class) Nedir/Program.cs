using System;

namespace Sınıf_Class__Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Class yapısının kullanılması bir programı parçalar halinde tasarlanmasını gerçeklirmek için 
              Mesela bir kütüphane programı yazılıyor biri veri tabanının güncellemesini biri aramasını biri gui ekranını yazıyor
              bu işlemleri farklı farklı kişiler yazar ve sonrasında birleştirilir
              Aynı zamanda bir işi yapan bir class yazdınız bunu başka başka başka programlarda kullanmanızı sağlar 
              sadece class dosyasını yeni programınıza eklemek yeterlidir
              buna örnek renklendirilmiş bir combobox yada veri tabanı işlemlerini yapan bir class 
              Tanımlaması Class isim {} içerisine eklediklerimizi public private olarak belirleyerek dış erişime açabiliriz
              sınıfı başka bir sınıf içerisinde kullanacaksak aynı değişken tanımlar gibi tanımlamamız gerekir.
            */
            DortIslem dortIslem = new DortIslem();
            dortIslem.islem('*', 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("İşlem sonucu={0}", dortIslem.sonuc);
            Console.WriteLine("---------------");
            dortIslem.islem('/', 81, 3, 27);
            Console.WriteLine("İşlem sonucu={0}", dortIslem.sonuc);
            Console.WriteLine("---------------");
            //Buraya kadar kendi içerisinde yer alan class oluşturduk harici class ise nesne ekleden eklenerek yapılacak
            kisiler kisi=new kisiler();
            kisi.Ad = "Serhan";
            kisi.Soyad = "Koral";
            kisi.Yas = 41;
            kisi.Yazdir();
            //bu şekilde ulaşıldığı gibi create yapılırkende ulaşılır
            kisiler kisi2 = new kisiler()
            {
                Ad = "Fatma",
                Soyad="KORAL",
                Yas=40                
            };
            kisi2.Yazdir();
            Console.ReadKey();
        }
    }
    class DortIslem
    {
        public double sonuc;
        private double temp_sonuc;
        public void islem(char islem, params double[] sayilar)
        {
            switch (islem)
            {
                case '+':
                    sonuc = 0;
                    temp_sonuc = 0;
                    foreach (var item in sayilar)
                    {
                        temp_sonuc = sonuc;
                        sonuc += item;
                        Console.WriteLine("{0} + {1}={2}", temp_sonuc, item, sonuc);
                    }
                    break;
                case '-':
                    sonuc = 0;
                    temp_sonuc = 0;
                    foreach (var item in sayilar)
                    {
                        temp_sonuc = sonuc;
                        sonuc -= item;
                        Console.WriteLine("{0} - {1}={2}", temp_sonuc, item, sonuc);
                    }
                    break;
                case '*':
                    sonuc = 1;
                    temp_sonuc = 0;
                    foreach (var item in sayilar)
                    {
                        temp_sonuc = sonuc;
                        sonuc *= item;
                        Console.WriteLine("{0} * {1}={2}", temp_sonuc, item, sonuc);
                    }
                    break;
                case '/':
                    sonuc = 1;
                    temp_sonuc = 0;
                    foreach (var item in sayilar)
                    {
                        temp_sonuc = sonuc;
                        if (sonuc == 1) { sonuc = item; }
                        else
                        {
                            sonuc /= item;
                            Console.WriteLine("{0} / {1}={2}", temp_sonuc, item, sonuc);
                        }
                    }
                    break;

                default:
                    break;

            }
        }
    }
}
