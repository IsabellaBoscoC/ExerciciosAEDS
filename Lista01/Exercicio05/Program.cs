
using System;
class Program
{
    static int MDC(int x, int y) //função
    {
        if (y == 0) // - caso de parada 
        {
            return x; 
        }

        else
        {
            return  MDC(y, x%y);// formula geral 
        }
    }

    static void Main() //inicio do programa
    {
        int resposta, x, y;

        Console.Write("Por favor, digite um número inteiro para 'x': ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Por favor, digite um número inteiro para 'y': ");
        y = int.Parse(Console.ReadLine());


        resposta = MDC(x,y);
        Console.WriteLine(resposta);
       

        Console.WriteLine("--FIM DO PROGRAMA--");
    }
}




