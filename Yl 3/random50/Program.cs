using System;

//Arvu äraarvamise mäng


namespace random50
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randNumber = random.Next(1, 50);

            Console.WriteLine("Arvuti genereeris suvalise arvu vahemikus 1 kuni 50, proovi arvata õigesti!");

            guessingNumber(randNumber);

        }

        public static void guessingNumber(int randNumber)
        {
            int count = 0;

            while (true)
            {
                string userInput = Console.ReadLine();

                if (String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine($"Lõpetasid mängu! Kahjuks ei leidnud õiget vastust. Arvasid {count} korda.");
                    break;
                }

                count++;
                int answer = Int32.Parse(userInput);

                if (answer == randNumber)
                {
                    Console.WriteLine($"Võitsid mängu! Õige vastus oli {randNumber}. Arvasid {count} korda.");
                    break;
                }
                else if (answer < randNumber)
                {
                    Console.WriteLine("Salajane arv on suurem.");
                }
                else if (answer > randNumber)
                {
                    Console.WriteLine("Salajane arv on väiksem.");
                }

            }



        }
    }
}
