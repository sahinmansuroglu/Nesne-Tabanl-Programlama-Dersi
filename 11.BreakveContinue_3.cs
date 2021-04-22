class Program
    {

        //1 ile 20 arasındaki tek sayıları continue kullanarak yazdırınız
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0) continue;

                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
