using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;

namespace Lista3
{
    internal class Program
    {
        static string Cin(string texto = "")
        {
            System.Console.Write(texto);
            texto = System.Console.ReadLine();
            return texto;
        }

        static void Cout(string texto = "")
        {
            System.Console.WriteLine(texto);
        }

        static void Exercicio1()
        {
            Cout("Exercício 1\n\n");
            Cout("1. Crie um programa que define um vetor de tamanho N, faz a leitura dos N" +
                "números float e apresenta, com base nos números digitados, " +
                "o menor número, o maior número e a média aritmética dos números.");
            Cout("\n\n");
            try
            {
                Cout("Informe o valor de N - quantidade de números a serem inseridos no vetor: ");
                int N = int.Parse(Console.ReadLine());
                if (N < 0) throw new Exception(" vetor de tamanho zero ou negativo");
                float maior, menor, media, soma = 0;
                float[] v = new float[N];
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Entre o valor {i + 1}:      ");
                    v[i] = float.Parse(Console.ReadLine());
                }
                menor = maior = v[0];
                foreach (float k in v)
                {
                    if (k > maior) maior = k;
                    if (k < menor) menor = k;
                    soma += k;
                }
                media = soma / N;
                Cout("\nO menor número é " + menor + " .");
                Cout("O maior número é " + maior + " .");
                Cout("A média dos valores é " + media + " .");
            }
            catch (Exception err)
            {
                Cout("Entrada inválida.\n" + err.Message + "\n\n");
            }

            return;
        }


        static void Exercicio2()
        {
            Cout("Exercício 2\n\n");
            Cout("2. Crie um programa que define um vetor de tamanho N, " +
                "onde N é informado pelo usuário (você precisa garantir que o valor de N é maior que zero). " +
                "Em seguida, faça a leitura dos N  números e mostre ao final apenas os números contidos no " +
                "vetor que são maiores ou iguais à média de todos os números digitados.");
            Cout("\n\n");

            try
            {
                int N = 0;
                while (N <= 0)
                {
                    if (N <= 0) Cout("\n\nO valor de N precisa ser maior que zero");
                    Console.Write("Informe o valor de N - quantidade de números a serem inseridos no vetor: ");
                    N = int.Parse(Console.ReadLine());
                    //if (N < 0) throw new Exception(" vetor de tamanho zero ou negativo");
                }
                float maior, menor, media, soma = 0;
                float[] v = new float[N];
                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Entre o valor {i + 1}:      ");
                    v[i] = float.Parse(Console.ReadLine());
                    soma += v[i];
                }
                media = soma / N;
                Console.Write("\n\nValores maiores que a média: \n[ ");
                for (int i = 0; i < N; i++)
                {
                    if (v[i] >= media)
                    {
                        
                        Console.Write(v[i] + ", ");
                        
                    }
                }




                Console.Write(" ]\n\n");
            }
            catch (Exception err)
            {
                Cout("Entrada inválida.\n" + err.Message + "\n\n");
            }

            return;
        }

        static void Exercicio3()
        {
            Cout("Exercício 3\n\n");
            Cout("3. Utilizando o exercício anterior, altere seu programa para que a inclusão dos números " +
                "seja feita automaticamente. Pesquise por geração de números aleatórios em C#.");
            Cout("\n\n");

            try
            {
                int N = 0;
                Random rd = new Random();
                while (N <= 0)
                {
                    if (N <= 0) Cout("\n\nO valor de N precisa ser maior que zero");
                    Console.Write("Informe o valor de N - quantidade de números a serem inseridos no vetor: ");
                    N = int.Parse(Console.ReadLine());
                    //if (N < 0) throw new Exception(" vetor de tamanho zero ou negativo");
                }
                float maior, menor, media;
                double soma = 0;
                float[] v = new float[N];
                for (int i = 0; i < N; i++)
                {
                    v[i] = Convert.ToSingle(rd.NextDouble());
                    soma += v[i];
                }
                media = Convert.ToSingle(soma / N);
                Console.Write("\n\nValores maiores que a média: \n[ ");
                for (int i = 0; i < N; i++)
                {
                    if (v[i] >= media)
                    {
                        Console.Write(v[i] + " ;   ");
                    }
                }

                Console.Write(" ]\n\n");
            }
            catch (Exception err)
            {
                Cout("Entrada inválida.\n" + err.Message + "\n\n");
            }


            return;
        }
        static void Exercicio4()
        {
            Cout("Exercício 4\n\n");
            Cout("4. Utilizando o conceito de matrizes em C# codifique um jogo da velha.");
            Cout("\n\n");

            string print_casa(int tipo)
            {
                if (tipo == 1)                
                    return " O ";                
                if (tipo == 2)                
                    return " X ";                
                return "   ";
            }

            void print_game(int[,] estado) {
                Console.Clear();
                int linha = 0;
                char[] letra = new char[3]; letra[0] = 'A'; letra[1] = 'B'; letra[2] = 'C';
                Console.WriteLine("    1     2     3");
                for (int l = 0; l < 3; l++)
                {
                    Console.Write(letra[l] + "  ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(print_casa(estado[l, i]));
                        if (i == 0 || i == 1)
                            Console.Write(" | ");
                    }
                    if (l == 0 || l == 1)
                        Console.Write("\n--------------------");
                    Console.Write("\n");
                }
            }

            int[] pegar_escolha(string escolha)
            {
                int[] posicao = new int[2];
                posicao[0] = posicao[1] = 0;
                if (escolha.Length == 0 || escolha.Length > 2) throw new Exception("Opção inválida");//testar para ver se nao pega char de fim de linha
                char linha = escolha.ToUpper()[0];
                char coluna = escolha[1];
                if (!(coluna == '1' || coluna == '2' || coluna == '3') || !(linha != 'A' || linha != 'B' || linha != 'C')) throw new Exception("Opção inválida");

                switch (linha)
                {
                    case 'A':
                        posicao[0] = 0;
                        break;
                    case 'B':
                        posicao[0] = 1;
                        break;
                    case 'C':
                        posicao[0] = 2;
                        break;
                }
                switch (coluna)
                {
                    case '1':
                        posicao[1] = 0;
                        break;
                    case '2':
                        posicao[1] = 1;
                        break;
                    case '3':
                        posicao[1] = 2;
                        break;
                }
                return posicao;
            }

            int[] gerar_casa_random()
            {
                Random random = new Random();
                int[] posicao = new int[2];
                int rd = random.Next(0, 9);
                posicao[0] = rd / 3;
                posicao[1] = rd % 3;
                return posicao;
            }

            bool escolha_e_invalida(int[] posicao, int[,] game)
            {
                return (game[posicao[0], posicao[1]] > 0);
            }
            int ha_vencedor(int[,] game)
            {
                bool teste;
                for (int i = 0; i < 3; i++)
                {
                    teste = (game[i, 0] == game[i, 1]) && (game[i, 0] == game[i, 2]); // verificando linhas ==
                    if (teste) return game[i, 0];
                    teste = (game[0, i] == game[1, i]) && (game[0, i] == game[2, i]); // verificando colunas |||
                    if (teste) return game[0, i];
                }
                teste = (game[0, 0] == game[1, 1]) && (game[0, 0] == game[2, 2]);//diagonal \
                if (teste) return game[0, 0];
                teste = (game[0, 2] == game[1, 1]) && (game[0, 2] == game[2, 0]);//diagonal /
                if (teste) return game[0, 0];

                return 0;
            }

            try
            {
                int[,] game = new int[3, 3]; // 0 = vazio, 1 = O, 2 = X
                for(int i = 0; i < 9; i++)
                    game[i / 3, i % 3] = 0;
                int casas_usadas = 0;
                int vez = 0;

                //System.Threading.Thread.Sleep(1000);

                while (casas_usadas < 9 && ha_vencedor(game) == 0)
                {
                    bool escolha_invalida = true;
                    int[] posicao = new int[2];
                    string escolha;
                    Console.Clear();
                    print_game(game);

                    if (vez % 2 == 0)
                    {
                        while (escolha_invalida)
                        {
                            for (int i = 0; i < 40; i++)
                            {
                                System.Threading.Thread.Sleep(5);
                                Console.Write('<');
                            }
                            Console.Write("\n\nSua Vez. Escolha uma casa: ");
                            escolha = Console.ReadLine();
                            posicao = pegar_escolha(escolha);
                            escolha_invalida = escolha_e_invalida(posicao, game);
                            if (escolha_invalida)
                            {
                                Console.WriteLine("Escolha Inválida. A casa já está sendo usada. Tente outra...\n");
                                System.Threading.Thread.Sleep(400);
                                continue;
                            }
                        }
                        game[posicao[0], posicao[1]] = 1 + vez % 2;
                        casas_usadas++;
                        vez++;
                        Console.WriteLine("OK...\n\n\n");
                        System.Threading.Thread.Sleep(200);
                    }
                    else
                    {
                        if (vez >= 9) continue;
                        Console.WriteLine($"Minha vez...\n\n");
                        for (int i = 0; i < 40; i++)
                        {
                            System.Threading.Thread.Sleep(8);
                            Console.Write('>');
                        }
                        do {
                            posicao = gerar_casa_random();
                        } while (escolha_e_invalida(posicao, game));
                        game[posicao[0], posicao[1]] = 1 + vez % 2;
                        casas_usadas++;
                        vez++;
                    }
                }


                Console.Clear();
                print_game(game);

                for (int i = 0; i < 40; i++)
                {
                    System.Threading.Thread.Sleep(5);
                    Console.Write('=');
                }
                System.Threading.Thread.Sleep(300);
                int vencedor = ha_vencedor(game);
                Console.WriteLine("\n\n");
                switch (vencedor)
                {
                    case 0: 
                        Console.WriteLine("Ninguém ganhou");
                        break;
                    case 1: 
                        Console.WriteLine("Parabéns! Você ganhou");
                        break;
                    case 2: 
                        Console.WriteLine("Você perdeu!");
                        break;
                }
                System.Threading.Thread.Sleep(2800);






            }
            catch(Exception error)
            {
                Console.WriteLine("erro" + error.Message);
            }





            return;
        }


        static void Main(string[] args)
        {
            bool escolhendo_opcao = true;
            bool opcao_valida = false;
            string opcao = "";
            Cout("Lista 3\n\n");
            while (true)
            {
                int programa_inicial = 1, programa_final = 4;
                opcao = Cin("Selecione o número do exercício para executar (de " +
                    programa_inicial + " a " + programa_final +
                    ") ou escreva <sair> para terminar o programa:  ");
                if (opcao.ToLower() == "sair" || opcao.ToLower() == "<sair>") break;
                try
                {
                    int numero = Convert.ToInt32(opcao);
                    opcao_valida = (numero >= 1 && numero <= 4);
                    if (!opcao_valida)
                    {
                        Cout("\n\nOpcao Invalida\n\n");
                        Cin("\n\n\nPrecione qualquer tecla para voltar ao menu...");
                        System.Console.Clear();
                        continue;

                    }
                    else
                    {
                        switch (opcao)
                        {
                            case "1":
                                Exercicio1();
                                break;
                            case "2":
                                Exercicio2();
                                break;
                            case "3":
                                Exercicio3();
                                break;
                            case "4":
                                Exercicio4();
                                break;
                        }
                        Cin("\n\n\nPrecione qualquer tecla para voltar ao menu...");
                        System.Console.Clear();
                    }
                }
                catch
                {
                    System.Console.Clear();
                    Cout("Opcao Invalida\n\n\n");
                }
            }


            Cin("\n\n\nPrecione qualquer tecla para fechar...");
        }
    }
}


