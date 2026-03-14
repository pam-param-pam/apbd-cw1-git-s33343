
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("Papier Kamień Nożyce");
        Console.WriteLine("1 - Kamień");
        Console.WriteLine("2 - Papier");
        Console.WriteLine("3 - Nożyce");
        Console.Write("Twój wybór: ");

        int player = int.Parse(Console.ReadLine());
        int computer = rand.Next(1, 4);

        Console.WriteLine("Komputer: " + computer);

        if (player == computer)
            Console.WriteLine("Remis");
        else if ((player == 1 && computer == 3) ||
                 (player == 2 && computer == 1) ||
                 (player == 3 && computer == 2))
            Console.WriteLine("Wygrywasz!");
        else
            Console.WriteLine("Przegrywasz!");
    }
}