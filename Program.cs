using System;
using System.Collections.Generic;

namespace matriz_exame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A execução do programa final deverá seguir, na sequência, os 3 passos abaixo. Explicando pro usuário \n" +
                "o que vai acontecer, mostrando o que é proposto, e aguardando um confirmação do usuário pra seguir ao próximo passo: \n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Crie um programa que construa uma matriz 5 x 5. Cada posição dessa matriz será preenchida com um número\n" +
                "randômico entre -15 e 15. Não é permitido números repetidos na matriz.");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.Write("Deseja executar o 1º Passo 1 ?  S/N ");
            if (Console.ReadLine().ToLower() == "n")
            {
                Environment.Exit(0);
            }

            Random r = new Random();

            int linhas = 5;
            int colunas = linhas;

            int[,] Matriz1 = new int[linhas, colunas];
            int num;

            Console.WriteLine("\nLegenda: Matriz[linha, coluna]: valor\n");

            for (int i = 0; i < linhas; i++)
            {

                for (int j = 0; j < colunas; j++)
                {

                //verificando se existe numero antes de inserir

                gera_numero_aleatorio:
                    num = r.Next(-15, 15);

                    foreach (var item in Matriz1)
                    {
                        if (item == num)
                        {
                            goto gera_numero_aleatorio;
                        }
                    }

                    Matriz1[i, j] = num;
                    Console.WriteLine($"Matriz[{i + 1}, {j + 1}]: {Matriz1[i, j]}");
                }

            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("O programa deverá ler a matriz criada anteriormente e separar os números encontrados em 2 vetores diferentes,\n" +
                "sendo um vetor com os valores pares encontrados e outro vetor com valores ímpares.");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.Write("Deseja executar o 2º Passo ?  S/N ");
            if (Console.ReadLine().ToLower() == "n")
            {
                Environment.Exit(0);
            }

            List<int> numPares = new List<int>();
            List<int> numImpares = new List<int>();
            foreach (var item in Matriz1)
            {
                if (item % 2 == 0)
                {
                    numPares.Add(item);
                }
                else
                {
                    numImpares.Add(item);
                }
            }

            Console.WriteLine("Números pares:\n" + String.Join(", ", numPares));
            Console.WriteLine("Números impares:\n" + String.Join(", ", numImpares));

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Os dois vetores deverão ser ordenados, o vetor com os pares deverão estar em ordem crescente," +
                "\ne os ímpares em ordem decrescente, e assim apresentados na tela ao usuário.");


            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.Write("Deseja executar o 3º Passo ?  S/N ");
            if (Console.ReadLine().ToLower() == "n")
            {
                Environment.Exit(0);
            }

            int l, c, temp; // variáveis pra orderanação
            // ordenando array numero pares
            for (l = 1; l < numPares.Count; l++)
            {
                temp = numPares[l];
                c = l;
                while ((c > 0) && (numPares[c - 1] > temp))
                {
                    numPares[c] = numPares[c - 1];
                    c--;
                }
                numPares[c] = temp;
            }

            Console.WriteLine("Números pares ordem crescente:\n" + String.Join(", ", numPares));
            
            // ordenando array numero impares
            for (l = 1; l < numImpares.Count; l++)
            {
                temp = numImpares[l];
                c = l;
                while ((c > 0) && (numImpares[c - 1] < temp))
                {
                    numImpares[c] = numImpares[c - 1];
                    c--;
                }
                numImpares[c] = temp;
            }

            Console.WriteLine("Números impares ordem decrescente:\n" + String.Join(", ", numImpares));

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.Write("Os 3 passos foram concluidos. Digite qualquer tecla pra sair ");
            if (Console.ReadKey() != null)
            {
                Environment.Exit(0);
            }
        }
    }
}
