
using System;
class Program
{
    static int FatDuplo(int n) //função
    {
        if (n == 1) // - caso de parada ->  fatorial duplo de 1 é 1
        {
            return 1; //caso base
        }

        else
        {
            return n * FatDuplo(n - 2);// formula geral -> n-2 porque so multiplica os numeros impares, faz isso ate chegar no 1 e ir para o caso base
        }
    }

    static void Main() //inicio do programa
    {
        int resposta, n;

        Console.Write("Por favor, digite um número inteiro positivo impar para 'n': ");
        n = int.Parse(Console.ReadLine());

        if (n % 2 == 0 || n < 1) // numero deve ser impar e positivo
        {
            Console.Write("O numero não se enquadro em inteiro positivo impar ");
        }

        else
        {
            resposta = FatDuplo(n);
            Console.WriteLine(resposta);
        }


        Console.WriteLine("--FIM DO PROGRAMA--");
    }
}



