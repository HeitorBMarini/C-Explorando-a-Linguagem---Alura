using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        //rendimento de 0.5% (0.005) mensal

        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);

        int mes = 1;
       while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + "você tem " + investimento);

            // mes = mes + 1
            mes = mes + 1;
        }

        Console.ReadLine();
    }

}
