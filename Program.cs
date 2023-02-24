using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lista2
{

    public static class Program
    {

        static string Cin(string texto = "")
        {
            System.Console.WriteLine(texto);
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
            Cout("Escreva um programa que obtenha 172 valores inteiros no intervalo [23, 9568], encontre o maior e\r\no menor entre eles e, ao final, mostre a média aritmética de todos os valores pares e menor que 100,\r\no menor e o maior número encontrado.");
            Cout("\n\n");
            try
            {
                int soma = 0, maior = 0, menor = 0, count = 172, soma_pares_menores_que_100 = 0, count_pares_menores_que_100 = 0, n = 0;
                Random random = new Random();
                for (int i = 0; i < count; i++) {
                    n = random.Next(23, 9568);
                    if (n < menor || i == 0) menor = n;
                    if (n > maior || i == 0) maior = n;
                    soma += n;
                    if (n < 100 && n %2 == 0)
                    {
                        soma_pares_menores_que_100 += n;
                        count_pares_menores_que_100++;
                    }

                    Console.Write(n + ", ");
                }

                double media = (double)soma / (double)count;
                double media_pares = (double) soma_pares_menores_que_100 / (double) count_pares_menores_que_100;

            }
            catch
            {
                Cout("Entrada Inválida\n\n");
            }
            return;
        }

        static void Exercicio2()
        {
            Cout("Exercício 2\n\n");
            Cout("Faça um programa que calcule a média de um conjunto de números digitados pelo usuário. O\r\nprograma deve permitir que o usuário digite uma quantidade não determinada de números,\r\nencerrando-se quando o usuário digitar um número negativo. Apresente a média aritmética dos\r\nnúmeros ao final da entrada de dados.");
            Cout("\n\n");
            try
            {

            }
            catch
            {
                Cout("Entrada Inválida\n\n");
            }
            return;
        }

        static void Exercicio3()
        {
            Cout("Exercício 3\n\n");
            Cout("Escreva um programa que mostre os números que possuem resto igual a 3 ou 5, quando divididos\r\npor 7. Considere o intervalo entre X e Y, incluindo os extremos. Os valores das variáveis X e Y são\r\ninformados pelo usuário.");
            Cout("\n\n");
            try
            {

            }
            catch
            {
                Cout("Entrada Inválida\n\n");
            }
            return;
        }

        static void Exercicio4()
        {
            Cout("Exercício 4\n\n");
            Cout("Faça um programa que leia um número P positivo e mostre na tela os P\r\n\r\n3 primeiros números pares\r\n\r\nque são ao mesmo tempo divisíveis por 4, mas não por 6.");
            Cout("\n\n");
            try
            {

            }
            catch
            {
                Cout("Entrada Inválida\n\n");
            }
            return;
        }

        static void Exercicio5()
        {
            Cout("Exercício 5\n\n");
            Cout("Crie um programa que seja capaz de apresentar uma figura similar à apresentada abaixo. O usuário\r\nentrará somente com o número de linhas e o caractere a ser utilizado na apresentação final. No\r\nexemplo, o número de linhas foi 5 e o caractere foi o asterisco.\n*\r\n**\r\n***\r\n****\r\n*****");
            Cout("\n\n");
            try
            {

            }
            catch
            {
                Cout("Entrada Inválida\n\n");
            }
            return;
        }

        static void Exercicio6()
        {
            Cout("Exercício 6\n\n");
            Cout("Crie um programa que seja capaz de apresentar uma figura similar à apresentada abaixo. O usuário\r\nentrará somente com o número de linhas e o caractere a ser utilizado na apresentação final. No\r\nexemplo, o número de linhas foi 5 e o caractere foi o asterisco.\n*\r\n***\r\n*****\r\n*******\r\n*********");
            Cout("\n\n");
            try
            {

            }
            catch
            {
                Cout("Entrada Inválida\n\n");
            }
            return;
        }



        static void Main(string[] args)
        {

            bool opcao_valida = false, sair = false;
            string opcao = "";
            Cout("LISTA 2\n\n");
            while (!sair)
            {   
                opcao = Cin("Informe a opção número do exercício para executar (de 1 a 6) ou escreva <sair> para terminar o programa.\nOpção: ");
                if (opcao.ToLower() == "sair" || opcao.ToLower() == "<sair>")
                {
                    sair = true;
                    Environment.Exit(0);
                }
                try
                {
                    int numero = Convert.ToInt32(opcao);
                    opcao_valida = (numero >= 1 && numero <= 12);
                    if (!opcao_valida)
                    {
                        System.Console.Clear();
                        Cout("Opção Inválida\n\n\n");
                        continue;
                    }
                }
                catch
                {
                    System.Console.Clear();
                    Cout("Opcao Invalida\n\n\n");
                    continue;
                }
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
                    case "5":
                        Exercicio5();
                        break;
                    case "6":
                        Exercicio6();
                        break;
                }
                Cin("Precione qualquer tecla para voltar ao menu...");
                System.Console.Clear();
            }
            Cin("Precione qualquer tecla para fechar...");
        }
    }
}
