 class Program
    {
        //Sınıf Kapsamı

        static int sayi;
        
        static void arttir()
        {

            sayi++;
        }
        
        static void azalt()
        {

            sayi--;
        }
       
       
        static void Main(string[] args)
        {
            sayi = 0;
            arttir(); arttir(); arttir();
            Console.WriteLine($"3 Arttırma sonrası sayi:{sayi}");
            azalt();azalt();
            Console.WriteLine($"2 Arttırma sonrası sayi:{sayi}");
            Console.ReadKey();
            
        }
    }
