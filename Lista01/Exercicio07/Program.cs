using System;
class Program
{
    //função de  Fatorial inico = posiçaõ zero e final = posição 9:
    static void InverterVetor(double[] numero, int inicio, int final) 
    //void pq nao vai retornar nada
    {
        if (inicio < final)
        {
            // Troca o elemento no início com o elemento no fim
            double temporario = numero[inicio];
            numero[inicio] = numero[final];
            numero[final] = temporario;

            // Chama a função recursivamente para inverter o restante do vetor
            InverterVetor(numero, inicio + 1, final - 1);
        }
    }
    static void Main() //inicio do programa
    {
        double[] numero = new double [10]; // criar vetor de tamanho 10, doble pq sao numeros reais

        //PREENCHER O VETOR:
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o valor para o elemento na posição [0]: ");
            numero[i] = double.Parse(Console.ReadLine());
        }

        //chamar uma funçaõ para inverter os valores do vetor numero
        InverterVetor(numero, 0, 9);

        //imprimir os vetores invertidos:
        Console.WriteLine("Vetor invertido:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine( numero[i] + "---");
        }

        Console.WriteLine("--FIM DO PROGRAMA--");
    }
}





