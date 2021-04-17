class Program
    {
      
        static void Main(string[] args)
        {

            string kisaltma = "ts";

            switch (kisaltma)
            {

                case "gs":
                    Console.WriteLine("Galatasaray");
                    break;
                case "fb":
                    Console.WriteLine("Fenerbahçe");
                    break;
                case "bjk":
                    Console.WriteLine("Beşiktaş");
                    break;
                case "ts":
                    Console.WriteLine("Trabzon Spor");
                    break;
                default:
                    Console.WriteLine("Hatalı Kısaltma");
                    break;
            }


            Console.ReadKey();
            
        }
    }
