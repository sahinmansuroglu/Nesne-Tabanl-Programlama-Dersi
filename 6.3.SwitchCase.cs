class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşlem Giriniz:(+, -, x, / )");
            char islem = (char) Console.Read();

            double sonuc = 0;
           

            switch (islem)
            {

                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case 'x':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = (double)sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Hatalı İşlem Girdiniz:");
                    break;
            }

            Console.WriteLine($"{ sayi1}{ islem}{ sayi2}={ sonuc} ");


            Console.ReadKey();
            
        }
    }
