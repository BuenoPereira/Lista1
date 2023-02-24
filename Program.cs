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
                double soma = 0, maior = 0, menor = 0, count = 172, soma_pares_menores_que_100 = 0, count_pares_menores_que_100 = 0, n = 0, media_pares = 0;
                Random random = new Random();
                Console.Write("\nValores:\n[ ");
                for (int i = 0; i < count; i++) {
                    n = random.Next(23, 9568);
                    if (n < menor || i == 0) menor = n;
                    if (n > maior || i == 0) maior = n;
                    soma += n;
                    if (n < 100 && n % 2 == 0)
                    {
                        soma_pares_menores_que_100 += n;
                        count_pares_menores_que_100++;
                    }
                    Console.Write(n);
                    if (i < count - 1) Console.Write(", ");
                }
                Cout("]\n\n");
                Cout("Sobre todos os valores: ");
                Cout("Maior valor: " + maior + " .");
                Cout("Menor valor: " + menor + " .");
                media_pares = soma_pares_menores_que_100 / count_pares_menores_que_100;
                if (!Double.IsNaN(media_pares))
                {
                    Cout("Média dos valores pares menores que 100: " + media_pares.ToString("N2") + " .");
                }
                else
                {
                    if (!(count_pares_menores_que_100 > 0)) Cout("Não foi possível calcular a média dos valores pares menores que 100 pois não há valores pares menores que 100.");
                    else Cout("Não foi possível calcular a média.");
                }
            }
            catch
            {
                Cout("Erro na execução do exercício 1\n\n");
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
                double soma = 0, n = 0, count = 0;
                int padding = 0;
                string texto = "\nValor: ";
                while (n >= 0)
                {
                    Console.Write(texto);
                    n = Convert.ToDouble(Console.ReadLine());
                    if (n >= 0) { 
                        count++;
                        soma += n;
                        padding = n.ToString().Length;
                        Console.SetCursorPosition(texto.Length + padding, Console.CursorTop - 1);
                        for (int i = 0; i <= 40 - padding; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(" ... média parcial: " + (soma / count).ToString("N2"));
                    }
                    else
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.Write("                                                                                                              \n");
                    }


                }
                Cout("\nMédia dos valores inseridos = " + (soma / count).ToString("N2") + "\n\n");

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
            Cout("Escreva um programa que mostre os números que possuem resto igual a 3 ou 5, quando divididos por 7. Considere o intervalo entre X e Y, incluindo os extremos. Os valores das variáveis X e Y são informados pelo usuário.");
            Cout("\n\n");
            try
            {
                int x, y, t;
                bool primeiro = true;
                Console.Write("Informe o valor do início do intervalo: ");
                x = int.Parse(Cin());
                Console.Write("Informe o valor do final do intervalo: ");
                y = int.Parse(Cin());
                Cout("Valores válidos: ");
                Console.Write("[ ");
                for (int i = x; i <= y; i++)
                {
                    t = i % 7;
                    if (t == 3 || t == 5)
                    {
                        if (i > x && !primeiro) Console.Write(", ");
                        Console.Write(i);
                        primeiro = false;
                    }
                }
                Console.Write(" ]\n\n\n");
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
            Cout("Faça um programa que leia um número P positivo e mostre na tela os P^3 primeiros números pares que são ao mesmo tempo divisíveis por 4, mas não por 6.");
            Cout("\n\n");
            try
            {
                int p, p3;
                Console.Write("Informe o valor de P: ");
                p = int.Parse(Cin());
                p3 = p*p*p; //  p3 =  Convert.ToInt32((Math.Pow(Convert.ToDouble(p),3.0)));
                if (p > 0) {
                    Console.SetCursorPosition(p.ToString().Length, Console.CursorTop - 1);
                    Console.Write("    ... intervalo de 0 a " + p3 + "\n\n");
                    Console.Write("\nvalores: [ ");
                    for (int i = 0; i <= p3; i += 4)
                    {
                        if(! (i%6 == 0)){
                            Console.Write(i);
                            if (i < p3 - 4) Console.Write(", ");
                        }
                    }
                    Console.Write(" ].\n\n");
                }
                else
                {
                    throw new Exception("valor não positivo");
                }

            }
            catch(Exception er)
            {
                Cout("Entrada Inválida: " + er.Message + "\n\n");
            }
            return;
        }

        static void Exercicio5()
        {
            Cout("Exercício 5\n\n");
            Cout("Crie um programa que seja capaz de apresentar uma figura similar à apresentada abaixo. O usuário entrará somente com o número de linhas e o caractere a ser utilizado na apresentação final. No exemplo, o número de linhas foi 5 e o caractere foi o asterisco: \n*\r\n**\r\n***\r\n****\r\n*****");
            Cout("\n\n");
            try
            {
                Console.Write("Informe o número de linhas :");
                int linhas = Convert.ToInt32(Cin());
                Console.Write("Informe o caracter escolhido :");
                char caracter = Cin()[0];
                string linha;
                Cout("\n");

                for (int i = 0 ; i < linhas; i++)
                {
                    linha = "";
                    for (int j = linhas - i - 1 ; j < linhas; j++)
                    {
                        linha += caracter;
                    }
                    Cout(linha);
                }

                Cout("\n\n");

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
            Cout("Crie um programa que seja capaz de apresentar uma figura similar à apresentada abaixo. O usuário entrará somente com o número de linhas e o caractere a ser utilizado na apresentação final. No exemplo, o número de linhas foi 5 e o caractere foi o asterisco.\n   *\n  ***\n *****\n*******\n\n");
            Cout("\n\n");
            try
            {
                Console.Write("Informe o número de linhas :");
                int linhas = Convert.ToInt32(Cin());
                Console.Write("Informe o caracter escolhido :");
                char caracter = Cin()[0];
                string linha;
                Cout("\n");

                for (int i = 0; i < linhas; i++)
                {
                    linha = "";
                    for (int k = 0; k <= linhas - i - 2; k++)
                    {
                        linha += " ";
                    }
                    for (int j = 0; j < (i+1)*2-1; j++)
                    {                       
                        linha += caracter;
                    }
                    Cout(linha);
                }
                Cout("\n\n");
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
                    else
                    {
                        System.Console.Clear();
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
