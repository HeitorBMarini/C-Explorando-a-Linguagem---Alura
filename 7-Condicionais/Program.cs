using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadeDiego = 15;
        int quantidadePessoas = 2;

        if(idadeDiego >= 18)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            if (quantidadePessoas >= 1)
            {
                Console.WriteLine("Ele está sozinho");
            }
            

            else
            {
                Console.WriteLine("Acesso negado");
            }
           
        }

        Console.ReadLine();
    }


}


