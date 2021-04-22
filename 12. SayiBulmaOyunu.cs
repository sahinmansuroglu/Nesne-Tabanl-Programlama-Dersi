using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        // Kolay (1-50) hak=10
        // Orta   (1-100) hak=10
        // Zor (1-500) hak=10
        static int oyunBaslatmaManusu()
        {
            Console.WriteLine("Yeni Oyun Başlatma Menüsü");
            Console.WriteLine("1-Kolay(1-50)");
            Console.WriteLine("2-Orta (1-100)");
            Console.WriteLine("3-Zor  (1-500)");
            Console.WriteLine("0-Çıkış");
            Console.Write("Seçiminiz(0-3)");
            int seciminiz = Convert.ToInt32(Console.ReadLine());
            if (seciminiz <= 3 || seciminiz >= 0)
                return seciminiz;
            else
                return 0;

        }

        static int rastgeleSayiUret(int secim)
        {
            Random rastgele = new Random();
            if (secim == 1)
                return rastgele.Next(1, 50);
            else if (secim == 2)
                return rastgele.Next(1, 100);
            else
                return rastgele.Next(1, 500);

        }
        static void bekle(int saniye)
        {
            System.Threading.Thread.Sleep(1000 * saniye);
        }

        static void Main(string[] args)
        {
            while (true)
            {
               int secim= oyunBaslatmaManusu();
                if (secim == 0)
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                    break;
                }
                int rastgeleSayi = rastgeleSayiUret(secim);
                Boolean tahminEdildi = false;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"{i}. tahmininizi Giriniz:");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sayı Kontrol Ediliyor");
                    bekle(1);
                    if (rastgeleSayi > sayi)
                        Console.WriteLine("Lütfen Sayıyı Büyültünüz...");
                    else if (rastgeleSayi < sayi)
                        Console.WriteLine("Lütfen Sayıyı Küçültünüz...");
                    else
                    {
                        Console.WriteLine($"Tebrikler {rastgeleSayi} sayısını {i}. denemenizde tahmin ettiniz..  ");
                        tahminEdildi = true;
                        break;
                    }
                }

                if (!tahminEdildi)
                    Console.WriteLine("ÜZgünüm Kaybettiniz Size verilen hakların tümünü kullandınız.");

                bekle(2);

            }
                bekle(1);
                Console.WriteLine("Çıkış Yapıdı");
                
        }
    }
}
