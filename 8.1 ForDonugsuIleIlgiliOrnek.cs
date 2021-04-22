 class Program
    {
        //Kullanıcıdan kaç sayı girmek istediği bilgisi istenilecek
        //Ardın istenilen adette "sayı" girdirilecek
        //Bu sayıların Toplamı ve ortalaması hesaplatılacak
        // Bu sayıların içerisindeki Tek ve çift Sayıların adedini buldurun
        // Bu sayıların en Büyük ve En küçüğünü buldurun
       
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç Sayı Girmek İstiyorsunuz:");
            int adet = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int enBuyuk=0,enKucuk=0;
            int teklerinAdet = 0, ciftlerAdet = 0;
       
            for (int i =0 ; i<adet; i++)
            {
                Console.WriteLine($"{i + 1}. Sayıyı Giriniz:");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + girilenSayi;
                if (girilenSayi % 2 == 1) teklerinAdet++;
                else ciftlerAdet++;
                if (i == 0)
                {
                    enBuyuk = girilenSayi;
                    enKucuk = girilenSayi;
                }
                
                if (enKucuk > girilenSayi)
                    enKucuk = girilenSayi;
                if (enBuyuk < girilenSayi)
                    enBuyuk = girilenSayi;

            }
            double ortalama = (double)toplam / adet;
            Console.WriteLine($"{adet} sayının toplamı={toplam}");
            Console.WriteLine($"{adet} sayının ortalaması={ortalama}");
            Console.WriteLine($"{adet} sayıda {teklerinAdet} tane tek Sayı vardır");
            Console.WriteLine($"{adet} sayıda {ciftlerAdet} tane çift Sayı vardır");
            Console.WriteLine($"{adet} sayının en büyüğü: {enBuyuk} ");
            Console.WriteLine($"{adet} sayının en küçüğü: {enKucuk} ");
            Console.ReadKey();
        }
    }
