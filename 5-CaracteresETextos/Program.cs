using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        
        Console.WriteLine(letra);

        letra = (char)65;

        Console.WriteLine(letra);

        string nome = "Danniel";
        Console.WriteLine(nome);

        string primeiraFrase = "Curso ";
        primeiraFrase = primeiraFrase + 2022;
        Console.WriteLine(primeiraFrase);
    }
}
