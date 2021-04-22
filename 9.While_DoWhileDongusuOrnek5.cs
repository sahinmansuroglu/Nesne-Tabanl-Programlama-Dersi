 class Program
    {

       //Klavyeden 0 girilene kadar sürekli sayı girilmesi istenecek
       //o girildiğinde ise o ana kadarki sayıların toplamı ekrana yazdırılacak
        static void Main(string[] args)
        {
            int i = 1;
            int toplam = 0;
            int girilenSayi=1;
            while (girilenSayi!=0)
            {   

                Console.WriteLine($"{i}. sayıyı Giriniz:");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + girilenSayi;
                i++;
            }

            Console.WriteLine($"Toplam={toplam}");

            Console.ReadKey();
        }
    }
