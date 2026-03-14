using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        int rounds = 0;
        int wins = 0;
        int losses = 0;
        int draws = 0;

        while (true)
        {
            Console.WriteLine("Papier Kamień Nożyce");
            Console.WriteLine("1 - Kamień");
            Console.WriteLine("2 - Papier");
            Console.WriteLine("3 - Nożyce");
            Console.WriteLine("0 - Wyjście");
            Console.Write("Twój wybór: ");

            int player = int.Parse(Console.ReadLine());

            if (player == 0)
                break;

            int computer = rand.Next(1, 4);

            Console.WriteLine("Komputer: " + computer);

            rounds++;

            if (player == computer)
            {
                Console.WriteLine("Remis");
                draws++;
            }
            else if ((player == 1 && computer == 3) ||
                     (player == 2 && computer == 1) ||
                     (player == 3 && computer == 2))
            {
                Console.WriteLine("Wygrywasz!");
                wins++;
            }
            else
            {
                Console.WriteLine("Przegrywasz!");
                losses++;
            }

            Console.WriteLine();
            Console.WriteLine($"Statystyki: Tury={rounds}, Wygrane={wins}, Przegrane={losses}, Remisy={draws}");
            Console.WriteLine();
        }

        Console.WriteLine("Koniec gry");
        Console.WriteLine($"Rozegrane tury: {rounds}");
        Console.WriteLine($"Wygrane: {wins}");
        Console.WriteLine($"Przegrane: {losses}");
        Console.WriteLine($"Remisy: {draws}");
    }
}