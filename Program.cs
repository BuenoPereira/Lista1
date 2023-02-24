using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lista1
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
            Cout("Para calcular vários tributos, a base de cálculo é o salário-mínimo. Faça um programa que leia o valor\r\ndo salário-mínimo atual e o valor do salário de uma pessoa. Calcular e imprimir quantos salários-\r\nmínimos líquidos ela ganha, considerando que há um desconto de 8,5% de INSS");
            Cout("\n\n");
            try
            {
                double salario = 0, salario_minimo = 0, quantidade_de_salarios_minimos;
                string s_salario_minimo = Cin("Informe o valor do  salário mínimo atual: ");
                string s_salario = Cin("Informe o valor do seu salário: ");
                salario = Convert.ToDouble(s_salario);
                salario_minimo = Convert.ToDouble(s_salario_minimo);
                quantidade_de_salarios_minimos = salario * (1.0 - 0.085) / salario_minimo;
                Cout("\n\nVocê ganha " + quantidade_de_salarios_minimos.ToString("N2") + " salários mínimos");
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
            Cout("2. Faça um programa que pede um valor ao usuário em metros e exiba o correspondente em centímetros e milímetros.");
            Cout("\n\n");
            try
            {
                double distancia_em_metros = 0;
                string s_distancia_em_metros = Cin("Informe o valor da distância em metros:");
                distancia_em_metros = Convert.ToDouble(s_distancia_em_metros);
                double distancia_em_centimetros = distancia_em_metros * 100.0;
                double distancia_em_milimetros = distancia_em_metros * 1000.0;
                Cout(distancia_em_metros.ToString() + " metros equivalem a " + distancia_em_centimetros.ToString() + " centimetros e a " + distancia_em_milimetros.ToString() + " milimetros");
            }
            catch
            {
                Cout("Entrada inválida para\n\n");
            }
            return;
        }

        static void Exercicio3()
        {
            Cout("Exercício 3\n\n");
            Cout("3. Faça um programa que solicite um valor em graus Fahrenheit e imprima o valor correspondente em graus Celsius usando as fórmulas que seguem: a. Usar uma variável float para ler o valor em Fahrenheit e a fórmula C=(f-32.0) * (5.0/9.0). b. Usar uma variável int para ler o valor em Fahrenheit e a fórmula C=(f-32)*(5/9).");
            Cout("\n\n");
            try
            {
                string s_gF = Cin("Informe o valor da temperatura em graus Fahrenheit:");
                float gF;
                gF = float.Parse(s_gF);
                float gC = (gF - 32.0f) * (5.0f / 9.0f);
                Cout(gF.ToString("N2") + " graus Fahrenheit equivalem a " + gC.ToString("N2") + " graus Celcius.");
            }
            catch
            {
                Cout("Entrada inválida\n\n");
            }
            return;

        }
        static void Exercicio4()
        {
            Cout("Exercício 4\n\n");
            Cout("4. Pesquise sobre a fórmula de cálculo do IMC (Índice de Massa Corporal) e crie um programa capaz de solicitar as informações, calcular e retornar o resultado.");
            Cout("\n\n");
            try
            {
                Cout("\n\nCalculadora de IMC (Índice de Massa Corporal)\n\n");
                string s_peso = Cin("Informe o seu peso (em kilogramas):");
                string s_altura_cm = Cin("Informe sua altura (em centimetros):");
                double imc;
                imc = Convert.ToDouble(s_peso) / System.Math.Pow((Convert.ToDouble(s_altura_cm) / 100), 2);
                Cout("O seu IMC é " + imc.ToString("N1") + " .");
            }
            catch
            {
                Cout("Entrada inválida");
            }
            return;
        }
        static void Exercicio5()
        {
            Cout("Exercício 5\n\n");
            Cout("5. Faça um programa que solicite ao usuário três números e três pesos. Em seguida, calcule a média ponderada. Imprima o resultado.");
            try
            {
                int quantidade_de_numeros = 3;
                double[] valor = new double[quantidade_de_numeros];
                double[] peso = new double[quantidade_de_numeros];
                double dividendo = 0.0, divisor = 0.0;
                string media_ponderada = "";
                for (int i = 0; i < quantidade_de_numeros; i++)
                {
                    valor[i] = Convert.ToDouble(Cin("Informe o valor do " + (i+1).ToString() + "º número: "));
                    peso[i] = Convert.ToDouble(Cin("Informe o peso  do " + (i + 1).ToString() + "º número: "));
                }
                for (int i = 0; i < quantidade_de_numeros; i++)
                {
                    dividendo += peso[i] * valor[i];
                    divisor += peso[i];
                }
                media_ponderada = (dividendo / divisor).ToString("N2");
                Cout("\n\nA média ponderada dos valores informados é " + media_ponderada + ".\n\n");
            }
            catch
            {
                Cout("Entrada inválida");
            }            
            return;
        }
        static void Exercicio6()
        {
            Cout("Exercício 6\n\n");
            Cout("6. Escolha uma fórmula da física para codificar, solicite as informações necessárias para o cálculo e apresente o resultado.");
            Cout("\n\nCalculo de potência a partir da corrente elétrica e tensão elétrica\n\n");
            double corrente, tensao, potencia;
            try
            {
                corrente = (Convert.ToDouble(Cin("Informe o valor da corrente elétrica em Amperes: ")));
                tensao   = (Convert.ToDouble(Cin("Informe o valor da tensão elétrica em Volts: ")));
                potencia = corrente * tensao;
                Cout("\nO valor da potência do circuito é de " + potencia.ToString("N2") + " Watts.\n\n");
            }
            catch
            {
                Cout("Entrada inválida");
            }
            return;
        }
        static void Exercicio7()
        {
            Cout("Exercício 7\n\n");
            Cout("7. Escreva um algoritmo que receba o salário de um funcionário, calcule e mostre o novo salário, sabendo-se que este sofreu um aumento de 33,7%.");
            double salario_novo, salario_atual;
            try
            {
                Cout("\n\nInforme o valor do salário atual do funcionário para aplicar um aumento de 33,7%:");
                Console.Write("R$ ");
                salario_atual = Convert.ToDouble(Console.ReadLine().ToString().TrimStart('R','$', ' '));
                salario_novo = salario_atual * 1.337;
                Cout("\n\nO salário novo é de R$ " + salario_novo.ToString("N2") + ".\n\n");
            }catch{
                Cout("Entrada inválida");
            }
            return;
        }
        static void Exercicio8()
        {
            Cout("Exercício 8\n\n");
            Cout("8. Leia um valor em real e a cotação do dólar. Em seguida, imprima o valor correspondente em dólares.");
            double reais, cotacao;
            try{
                reais = Convert.ToDouble(Cin("Informe o montante em Reais: "));
                cotacao = Convert.ToDouble(Cin("Informe a cotação do Dolar: "));
                Cout("O valor correspondente é " + (reais * cotacao).ToString("N2") + " dolares.");
            }catch{
                Cout("Entrada inválida");
            }
            return;
        }
        static void Exercicio9()
        {
            Cout("Exercício 9\n\n");
            Cout("9. Leia um número inteiro e imprima a soma do antecessor do seu triplo com o sucessor do seu dobro.");
            int n,r;
            try{
            n = int.Parse(Cin("\n\ninforme o número: "));
            r = (3 * n - 1) + (2 * n + 1);
            Cout("O resultado é " + r.ToString() + ".\n\n");
            }
            catch{
                Cout("Entrada inválida");
            }
            return;
        }
        static void Exercicio10()
        {
            Cout("Exercício 10\n\n");
            Cout("10. Leia um número inteiro de 4 dígitos e imprima 1 dígito por linha.");
            Cout("\n\n");
            string s_num;
            int num;
            try {
                s_num = Cin("informe o número: ");
                num = Math.Abs(int.Parse(s_num));
                if (num <= 9999 && num >= 0) {
                    Cout("resultado:\n");
                    for (int i = 0; i < s_num.Length; i++) {
                        Cout(s_num[i].ToString());
                    }
                }
                else
                {
                    Cout("Entrada inválida");
                }                
                }catch{
                    Cout("Entrada inválida");
                }
            return;
        }
        static void Exercicio11()
        {
            Cout("Exercício 11\n\n");
            Cout("11. Marquesito, aluno do Instituto, começou a investir em criptomoedas. De início ele tem R$1000,00 para realizar seu primeiro investimento. No primeiro dia, seu patrimônio caiu 12,4%, no segundo subiu 1,8%, no terceiro subiu 5,6% e, no quarto caiu 4,5%. Crie um código para calcular qual o valor atual dos investimentos de Marquesito.");
            Cout("\n\n");
            double investimento = 1000.0 * 0.876 * 1.018 * 1.056 * 0.955;
            Cout("O valor atual dos investimentos de Marquesito é R$ " + investimento.ToString("N2") + " .");
            return;
        }
        static void Exercicio12()
        {
            Cout("Exercício 12\n\n");
            Cout("12. Tendo como dado de entrada à altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas: a. Para homens: (72.7*h) – 58 b. Para mulheres: (62.1*h) - 44.7");
            Cout("\n\n");
            try{
            string s_h = Cin("Informe o sua altura em centímetros: ");
            double h = Convert.ToDouble(s_h)/100;
            Cout("\nPara homens o peso ideal dessa altura é " + (72.7*h - 58).ToString("N2") + "Kg .");
            Cout("Para mulheres o peso ideal dessa altura é " + (62.1*h - 44.7).ToString("N2") + "Kg .\n\n");
            }
            catch{
                Cout("Entrada inválida");
            }
            return;
        }









        static void Main(string[] args)
        {

            Teste.metodo1("Teste metodi 1");
            bool opcao_valida = false, sair = false;
            string opcao = "";
            while (!sair)
            {
                opcao = Cin("Informe a opção número do exercício para executar (de 1 a 12) ou escreva <sair> para terminar o programa.\nOpção: ");
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
                    case "7":
                        Exercicio7();
                        break;
                    case "8":
                        Exercicio8();
                        break;
                    case "9":
                        Exercicio9();
                        break;
                    case "10":
                        Exercicio10();
                        break;
                    case "11":
                        Exercicio11();
                        break;
                    case "12":
                        Exercicio12();
                        break;
                }
                Cin("Precione qualquer tecla para voltar ao menu...");
                System.Console.Clear();
            }
            Cin("Precione qualquer tecla para fechar...");
        }
    }
}
