using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("Atm' ye Hoşgeldiniz");
            Console.WriteLine("1 = bakiye sorgulama");
            Console.WriteLine("2 = para çekme");
            Console.WriteLine("3 = para yatırma");
            Console.WriteLine("4 = çıkış yapmak için");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz:" + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("kalan tutar: " + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                }
                else if (secim == "4")
                {
                    Console.WriteLine("Atm'den çıkış yapılıyor");
                    Console.WriteLine("Çıkış yapıldı iyi günler");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    Console.ReadLine();
                }
            }
        }
    }
}
