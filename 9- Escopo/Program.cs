using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Escopo");

        int idadeDiego = 15;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas >= 1;

        string textoAdicional ;

        //string texto adicional
        if (acompanhado == true)
        {
             textoAdicional = "Diego está acompanhado";
        }
        else
        {
             textoAdicional = "Diego não está acompanhado";
        }

        if (idadeDiego >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }

        Console.ReadLine();
    }
}