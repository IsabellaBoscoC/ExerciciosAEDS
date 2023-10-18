using System;
class Program
{
    static int NumerosPell(int n) //função
    {
        if (n == 0) // - caso de parada 
        {
            return 0; //caso base1
        }

        else if (n == 1) 
        { 
            return 1; //caso base2
        }

        else
        {
            return 2 * NumerosPell(n - 1) + NumerosPell(n - 2);// formula geral 
        }
    }

    static void Main() //inicio do programa
    {
        int resposta, n;

        Console.Write("Por favor, digite um número para 'n': ");
        n = int.Parse(Console.ReadLine());

        resposta = NumerosPell(n);
        Console.WriteLine(resposta);
      


        Console.WriteLine("--FIM DO PROGRAMA--");
    }
}


