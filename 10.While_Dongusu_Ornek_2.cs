 class Program
    {


        //5 ile 10 arasındaki sayıların faktoriyelini for ve while döngüsü kullanarak
        //tasarlayınız
        //5!=5*4*3*2*1

       static int faktoriyel(int sayi)
        {
                int i = 1;
                int sonuc = 1;
                while (i <= sayi)
                {
                    sonuc = sonuc * i;
                    i++;
                }
            return sonuc;
        }
        static void Main(string[] args)
        {
            for (int sayi = 5; sayi <= 10; sayi++)
            {
                int sonuc = faktoriyel(sayi);
                Console.WriteLine($"{sayi} sayısının faktöriyeli:{sonuc}");
            }
            

            Console.ReadKey();
        }
    }
