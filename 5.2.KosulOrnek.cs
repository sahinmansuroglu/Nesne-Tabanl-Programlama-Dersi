            int puan1 = 65;
            int puan2 = 100;
            double ort = (puan1 + puan2) / 2.0;

            Console.WriteLine($"Ortalama={ort}");
            
            if (ort>=85 && ort <=100)
            {
                    Console.WriteLine("Notunuz:5");
            }
            else if (ort >= 70 && ort <= 84)
            {
                Console.WriteLine("Notunuz:4");
            }
            else if (ort >= 60 && ort <= 69)
            {
                Console.WriteLine("Notunuz:3");
            }
            else if (ort >= 50 && ort <= 59)
            {
                Console.WriteLine("Notunuz:2");
            }
            else
            {
                    Console.WriteLine("Notunuz:1");

            }
