using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 120; // замените на нужное значение

        int minutes = (N / 60) % 60;

        Console.WriteLine("Количество полных минут с начала последнего часа: " + minutes);
    }
}
