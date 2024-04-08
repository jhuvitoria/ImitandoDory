using System.Reflection;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Imitando Dory");
Console.ResetColor();
Console.WriteLine();
Console.Write("Digite uma frase...: ");
 string frase = Console.ReadLine()!;
 
 string frasesEmBaleies = frase
    .Replace("a", "aaa")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("o", "ooo")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU");

Console.WriteLine($"\nEm Baleiês:\n\n{frasesEmBaleies}");
