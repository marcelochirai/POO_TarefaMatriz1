using System;

//Programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros.
namespace POO_TarefaMatriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número (Será criada uma matriz n X n, conforme o número digitado: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n]; //Matriz quadrada, linhas e colunas de mesmo valor

            Console.WriteLine("Digite os números, separados por espaço (Ex: 1 2 3): ");

            for (int i = 0; i < n; i++) //Limitando a linha conforme n
            {
                string[] values = Console.ReadLine().Split(' ');    //Recebe os dados inputados pelo usuário
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Mostrar a diagonal principal
            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            //Quantidade de valores negativos da matriz
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Números negativos: " + count);

        }
    }
}
