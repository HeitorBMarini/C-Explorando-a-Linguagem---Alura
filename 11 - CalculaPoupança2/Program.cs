using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança 2");



        //rendimento de 0.5% (0.005) mensal
        double investimento = 1000;

        
        int mes = 1;

        for (int mes = 1; mes <= 12; mes++)
        
        {
            investimento = investimento *=  0.005;
            Console.WriteLine("No mês " + mes + "você tem " + investimento);
        }



        Console.ReadLine();
    }

}

