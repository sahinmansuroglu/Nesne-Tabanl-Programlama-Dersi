class Program
    {
               
        
        static void arttir()
        {
            int sayi=0;
            sayi++;
        }
        
        static void azalt()
        {
            int sayi=0;
            sayi--;
        }
       
       
        static void Main(string[] args)
        {
            int  sayi = 0;
            arttir(); arttir(); arttir();
            Console.WriteLine($"3 Arttırma sonrası sayi:{sayi}");
            azalt();azalt();
            Console.WriteLine($"2 Azaltma sonrası sayi:{sayi}");
            Console.ReadKey();
            
        }
    }
