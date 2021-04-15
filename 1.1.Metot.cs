class Program
    {
        public static void ornekMetot(String ad,String soyad, int dogumTarihi)
        {
            int yas = 2021 - dogumTarihi;
            Console.WriteLine($"Merhaba {ad} {soyad}");
            Console.WriteLine($"Yaşınız:{yas}");
        }
        static void Main(string[] args)
        {
            ornekMetot("Ali","ER",1958);
            ornekMetot("Veli","AR",1985);
            ornekMetot("Serdar","TATLI",1965);

            Console.ReadLine();
        }
    }
