class Program
    {
        public static void topla(int s1,int s2)
        {
            int sonuc = s1 + s2;
            Console.WriteLine($"{s1} ve {s2} sayılarının toplamı={sonuc}");
        }
        static void Main(string[] args)
        {
            topla(95, 36);
            topla(25, 22);
            topla(21, 22);

            Console.ReadLine();
        }
    }
