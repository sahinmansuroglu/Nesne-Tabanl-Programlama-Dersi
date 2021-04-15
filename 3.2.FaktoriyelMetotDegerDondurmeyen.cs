// Geriye Değer Döndürmeyen Metot tasarımı ile Faktöriyel hesaplama
        public static void faktoriyel(int sayi)
        {

            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }
            Console.WriteLine($"{sayi} sayısının faktöriyeli ={sonuc}");
        }
       
        
        
        static void Main(string[] args)
        {
           
            for (int i = 5; i <= 15; i++)
            {
                faktoriyel(i);
                

            }
           
            Console.ReadLine();
        }
    }
