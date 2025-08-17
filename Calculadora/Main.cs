using System;
using Calculadora.Historico;
using Calculadora.Menus;
using Calculadora.Contas;

class Program
{
    // Main Principal
    public static void Main()
    {
        Console.WriteLine("Calcudora em C#, tenha bom uso!");

        while (true)
        {
            Menus.MenuPrincipal();

            string escolha = Console.ReadLine() ?? "";

            switch (escolha)
            {
                case "1":
                    Menus.MenuCalculadora();

                    string operacao = "";

                    // Primeiro número
                    double num1 = Contas.InserirValor(operacao);

                    // Operação
                    operacao = Contas.InserirOperacao();

                    // Segundo número
                    double num2 = Contas.InserirValor(operacao);

                    double resultado = Contas.Operacoes(num1, num2, operacao);

                    Console.WriteLine($"Resultado: {resultado:F2}");

                    break;
                case "2":
                    Historico.Mostrar();
                    break;
                case "3":
                    Historico.Apagar();
                    break;
                case "4":
                    Historico.Salvar();
                    break;
                case "5":
                    Menus.MenuOperacoes();
                    break;
                case "6":
                    Console.WriteLine("Obrigado por utilizar o programa!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção valida do menu");
                    break;
            }
        }
    }
}

