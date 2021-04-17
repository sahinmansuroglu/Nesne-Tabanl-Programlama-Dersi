class Program
    {
       
        static void Main(string[] args)
        {
            int rakam = 1;

            switch (rakam)
            {

                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                default:
                    Console.WriteLine("Rakamn 1 2 veya 4 ");
                    break;
            }


            Console.ReadKey();
            
        }
    }
