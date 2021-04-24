class Program
    {

        static string sezarSifrele(String veri, int key)
        {
            string sifreliVeri = "";
            foreach (char herBirKarakter in veri)
            {
                sifreliVeri += ((char)(herBirKarakter + key));
                
            }
            return sifreliVeri;

        }

        static string sezarSifreCoz(String sifreliVeri, int key)
        {
            string sifresizVeri = "";
            foreach (char herBirKarakter in sifreliVeri)
            {
                
                sifresizVeri += ((char)(herBirKarakter - key));
              
            }
            return sifresizVeri;

        }
        //Bir sayının pozitif bölenlerini ekrana yazdıralım
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menü:");
                Console.WriteLine("1- Sezar Şifreleme");
                Console.WriteLine("2- Sezar Şifre Çözücü");
                Console.WriteLine("0- Çıkış");
                Console.WriteLine("Seçiminiz(0-2):");
                int secim = Convert.ToInt32( Console.ReadLine());
                if (secim == 0) break;

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Şifrelenecek Kelimeyi Giriniz");
                        string veri = Console.ReadLine();
                        Console.WriteLine("Şifreleme Anahtarını Giriniz");
                        int key = Convert.ToInt32(Console.ReadLine());

                        String sifreliVeri = sezarSifrele(veri, key);
                        Console.WriteLine($"Şifreli Veri: {sifreliVeri}");
                        break;
                    case 2:
                        Console.WriteLine("Şifreli Kelimeyi Giriniz");
                        string sifreliVeri1 = Console.ReadLine();
                        Console.WriteLine("Şifreleme Anahtarını Giriniz");
                        int key1 = Convert.ToInt32(Console.ReadLine());

                        String hamVeri = sezarSifreCoz(sifreliVeri1, key1);
                        Console.WriteLine($"Şifresi Çözülmüş Veri: {hamVeri}");
                        break;
                    default:
                        break;
                }
            }
           
          
            Console.ReadKey();
        }
    }
