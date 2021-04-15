// Geriye Değer Döndüren Metot
        public static double ortalama(int s1,int s2,int s3)
        {
            int toplam = s1 + s2+ s3;
            double ort = toplam / 3.0;
            return ort;
        }
        static void Main(string[] args)
        {
            double ort = ortalama(95, 36, 25);
            Console.WriteLine($"Ortalama={ort}");
            Console.ReadLine();
        }
