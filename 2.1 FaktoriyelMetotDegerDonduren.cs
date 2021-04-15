 class Program
    {
        // Geriye Değer Döndüren Metot tasarımı ile Faktöriyel hesaplama
        public static int faktoriyel(int sayi)
        {

            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }
       
        
        
        static void Main(string[] args)
        {
            int sonuc;
            for (int i = 5; i <= 15; i++)
            {
                sonuc = faktoriyel(i);
                Console.WriteLine($"{i} sayısının faktöriyeli ={sonuc}");

            }
           
            Console.ReadLine();
        }
    }
