class Program
    {

        static void Main(string[] args)
        {
            int i = 0;
            while(i<10)
            {
                i++;
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
