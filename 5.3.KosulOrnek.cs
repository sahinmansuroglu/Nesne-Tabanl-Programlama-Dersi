using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       
       

        /*
         * if (koşul){
         *  şart doğru ise burası çalışır
         * }else{
         * şart yanlış ise bu bölüm çalışır
         * }
         */
       
        
        static void Main(string[] args)
        {

            int puan1 = 65;
            int puan2 = 100;
            double ort = (puan1 + puan2) / 2.0;

            Console.WriteLine($"Ortalama={ort}");
            
            if (ort>=85 )
            {
                    Console.WriteLine("Notunuz:5");
            }
            else if (ort >= 70 )
            {
                Console.WriteLine("Notunuz:4");
            }
            else if (ort >= 60)
            {
                Console.WriteLine("Notunuz:3");
            }
            else if (ort >= 50 )
            {
                Console.WriteLine("Notunuz:2");
            }
            else
            {
                    Console.WriteLine("Notunuz:1");

            }
           
            

            Console.ReadKey();
            
        }
    }
}
