class Program
    {

       
        
        // Geriye Değer Döndüren Metot
        public static int topla(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(topla(95, 36));
            int snc=topla(25, 22);
            Console.WriteLine(snc);
            snc= topla(21, 22);
            Console.WriteLine(snc);
            Console.ReadLine();
        }
    }
