// Geriye Değer Döndürmeyen Metot
        public static void ortalama(int s1,int s2,int s3)
        {
            int toplam = s1 + s2+ s3;
            double ort = toplam / 3.0;
            Console.WriteLine($"Ortalama={ort}");
        }
        static void Main(string[] args)
        {
            ortalama(45, 66, 77);
            ortalama(96, 64, 77);
            ortalama(80, 66, 77);
            Console.ReadLine();
        }
