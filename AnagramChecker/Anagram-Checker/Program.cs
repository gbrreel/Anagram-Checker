using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a primeira palavra:");
        string palavra1 = Console.ReadLine();

        Console.WriteLine("Digite a segunda palavra:");
        string palavra2 = Console.ReadLine();

        if (EhAnagrama(palavra1, palavra2))
        {
            Console.WriteLine("As palavras são anagramas.");
        }
        else
        {
            Console.WriteLine("As palavras NÃO são anagramas.");
        }
    }

    static bool EhAnagrama(string palavra1, string palavra2)
    {
        palavra1 = palavra1.ToLower();
        palavra2 = palavra2.ToLower();

        if (palavra1.Length != palavra2.Length)
        {
            return false;
        }

        return string.Concat(palavra1.OrderBy(c => c)) == string.Concat(palavra2.OrderBy(c => c));
    }

}