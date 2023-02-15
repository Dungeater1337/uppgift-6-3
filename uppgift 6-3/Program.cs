using System; 

namespace uppgift6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ");
            Console.WriteLine("\n1. Addera tre tal");
            Console.WriteLine("2. Största värde mellan två tal");
            Console.WriteLine("3. Avsluta programmet");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    int summa = Addera();
                    Console.WriteLine("talen blir " + summa);
                    break;

                case 2:
                    int stor = Största();
                    Console.WriteLine("Det största värdet är " + stor);
                    break;

                case 3:
                    Console.WriteLine("Du har valt att avsluta Programmet");
                    break;
            }

            static int Addera()
            {
                Console.WriteLine("Skriv in ett tal");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in ett tal");
                int tal2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in ett tal");
                int tal3 = int.Parse(Console.ReadLine());

                int summa = tal1 + tal2 + tal3;
                return summa;
                
            }

            static int Största()
            {
                Console.WriteLine("Skriv in ett tal");
                int tal1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Skriv in ett tal");
                int tal2 = int.Parse(Console.ReadLine());

                if(tal1 > tal2)
                {
                    return tal1;
                }

                else if(tal1 < tal2)
                {
                    return tal2;
                }

                else
                {
                    return 0;
                }
            }
        }
    }
}