using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais 2");

        int idadeDiego = 15;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas >= 1;
        bool grupo = true;

        if (idadeDiego >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }

        Console.ReadLine();
    }
}