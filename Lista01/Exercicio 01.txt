// See https://aka.ms/new-console-template for more information

using System;
class Program
{
    static int SomaCubo(int n) //função
    {
        if (n == 1) 
        {
            return 1; //caso base
        }

        else
        {
            return (int) Math.Pow(n,3)+ SomaCubo(n-1); // formula geral
        }
    }   


    static void Main() //inicio do programa
    {
        int resposta, n;

        Console.Write("Por favor, digite um número inteiro 'n': ");
        n = int.Parse(Console.ReadLine());

        resposta = SomaCubo(n);
        Console.WriteLine(resposta);


        Console.WriteLine("--FIM DO PROGRAMA--");
    }
}
