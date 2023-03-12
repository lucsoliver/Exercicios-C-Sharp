using System;
using System.Collections.Generic;

class exercicio3
{
   public static void Main()
    {
        Console.WriteLine("Digite uma lista de frutas (separadas por vírgulas):");
        string input = Console.ReadLine();

        string[] fruits = input.ToLower().Split(',');

        HashSet<string> uniqueFruits = new HashSet<string>();

        foreach (string fruit in fruits)
        {
            string formattedFruit = fruit.Trim().Substring(0, 1).ToUpper() + fruit.Trim().Substring(1);

            if (!uniqueFruits.Contains(formattedFruit))
            {
                uniqueFruits.Add(formattedFruit);
            }
        }

        Console.WriteLine("Lista de frutas únicas:");
        foreach (string fruit in uniqueFruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
