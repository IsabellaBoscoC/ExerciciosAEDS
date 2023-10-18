
using System;
class Program
{
    static int SomaSerie(int i, int k, int j) //função
    {
        if (i >= j)
        {
            return j; //caso base
        }

        else
        {
            return i + SomaSerie( i + k,  k,  j);// formula geral
        }
    }


    static void Main() //inicio do programa
    {
        int resposta, i, k, j;

        Console.Write("Por favor, digite um número inteiro para 'i': ");
        i = int.Parse(Console.ReadLine());

        Console.Write("Por favor, digite um número inteiro para 'j': ");
        j = int.Parse(Console.ReadLine());

        Console.Write("Por favor, digite um número inteiro para 'k': ");
        k = int.Parse(Console.ReadLine());


        resposta = SomaSerie( i,  k, j);
        Console.WriteLine(resposta);


        Console.WriteLine("--FIM DO PROGRAMA--");
    }
}

