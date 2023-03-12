using System;

class exercicio1
{
    public static void Main()
    {
        int groomGuests, brideGuests, groomPresent, bridePresent;

        Console.Write("Digite o número de convidados convidados pelo noivo: ");
        groomGuests = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de convidados convidados pela noiva: ");
        brideGuests = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de convidados presentes para o noivo: ");
        groomPresent = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de convidados presentes para a noiva: ");
        bridePresent = int.Parse(Console.ReadLine());

        if (groomPresent > groomGuests)
        {
            Console.WriteLine("O noivo convidou menos convidados do que os que realmente compareceram!");
        }
        else if (groomPresent == groomGuests)
        {
            Console.WriteLine("O noivo convidou o mesmo número de convidados que os que vieram.");
        }
        else
        {
            Console.WriteLine("O noivo convidou mais convidados do que aqueles que realmente vieram.");
        }

        if (bridePresent > brideGuests)
        {
            Console.WriteLine("A noiva convidou menos convidados do que os que realmente compareceram!");
        }
        else if (bridePresent == brideGuests)
        {
            Console.WriteLine("A noiva convidou o mesmo número de convidados que os que vieram.");
        }
        else
        {
            Console.WriteLine("A noiva convidou mais convidados do que aqueles que realmente vieram.");
        }

        Console.ReadKey();
    }
}
