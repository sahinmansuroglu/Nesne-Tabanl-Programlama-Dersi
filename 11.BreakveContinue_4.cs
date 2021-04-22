class Program
    {

        // Sonsuz bir While Döngüsü Oluşturarak 1 den 20 e kadar olan sayıları ekrana yazdır.
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                i++;
                 Console.WriteLine(i);
                if (i == 20) break;
               
            }


            Console.ReadKey();
        }
    }
