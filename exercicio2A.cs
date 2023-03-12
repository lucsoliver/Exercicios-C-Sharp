using System;

class exercicio2A
{
    public static void Main()
    {
        string[] guests = new string[5]; 

        for (int i = 0; i < guests.Length; i++)
        {
            Console.Write("Digite o convidado #{0}: ", i + 1);
            guests[i] = Console.ReadLine();
        }

        Console.WriteLine("\nLista de convidados:");
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }

        Console.ReadKey();
    }
}
