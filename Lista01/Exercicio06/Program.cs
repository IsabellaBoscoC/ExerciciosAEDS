using System;
class Program
{
    static int Fat(int n) //função de  Fatorial
    {
        if (n == 1) // - caso de parada 
        {
            return 1;
        }

        else
        {
            return n * Fat(n - 1);// formula geral para fatorial
        }
    }




    static int SuperFat(int n) //função de Super Fatorial
    {
        if (n == 1) // - caso de parada 
        {
            return 1;
        }

        else
        {
            return Fat(n) * SuperFat(n-1);// formula geral para superfatorial
        }
    }

    static void Main() //inicio do programa
    {
        int resposta, n;

        Console.Write("Por favor, digite um número inteiro para 'n': ");
        n = int.Parse(Console.ReadLine());

        resposta = SuperFat(n);
        Console.WriteLine(resposta);


        Console.WriteLine("--FIM DO PROGRAMA--");
    }
}





