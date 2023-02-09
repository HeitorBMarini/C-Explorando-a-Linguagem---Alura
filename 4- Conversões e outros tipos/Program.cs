using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Programa
{
    static void Main(string[] args)
    {
        double salario;

        salario = 3000.40;
        Console.WriteLine(salario); 

        int SalarioInteiro = (int)salario;
        Console.WriteLine(SalarioInteiro);   

        //long é um tipo de variavel de 64 bits
        long x = 400000000000;
        Console.WriteLine(x);

      
        short y = 1800 ;
        Console.WriteLine(y);

        float altura = 1.86f;
        Console.WriteLine(altura);

        Console.WriteLine("Pressione enter para fechar......");
        Console.ReadLine();
    }


}
