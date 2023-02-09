using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caractres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);


        string primeiraFrase = "Alura e FIAP";
        Console.WriteLine(primeiraFrase + 2023);

        string cursos = @"Python 
- Java 
- Web 
- C#";
        Console.WriteLine(cursos);

        Console.ReadLine ();
    }


}



