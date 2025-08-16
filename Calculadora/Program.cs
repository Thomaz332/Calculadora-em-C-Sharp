using System;

class Program
{

    public static void MenuPrincipal()
    {   
        Console.WriteLine("\n1 - Nova Operação");
        Console.WriteLine("2 - Ver Histórico");
        Console.WriteLine("3 - Apagar Histórico");
        Console.WriteLine("4 - Salvar Histórico");
        Console.WriteLine("5 - Ajuda");
        Console.WriteLine("6 - Sair");
       
    }
    public static void MenuCalculadora()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n╔═══════════════╗");
        Console.WriteLine("║ % | q | r | / ║");
        Console.WriteLine("║ 7 | 8 | 9 | x ║");
        Console.WriteLine("║ 4 | 5 | 6 | - ║");
        Console.WriteLine("║ 1 | 2 | 3 | + ║");
        Console.WriteLine("║   | 0 |   | ^ ║");
        Console.WriteLine("╚═══════════════╝");
        Console.ResetColor();
    }

    public static void MenuAjuda()
    {
        Console.WriteLine("\nOperações disponíveis");
        Console.WriteLine("+ : Soma           |  - : Subtração");
        Console.WriteLine("x : Multiplicação  |  / : Divisão");
        Console.WriteLine("q : Quadrado       |  r : Raiz");
        Console.WriteLine("% : Porcentagem    |  ^ : Potência");
        Console.WriteLine("\nGuia de uso");
        Console.WriteLine("1. Selecione a opção Nova Operação");
        Console.WriteLine("2. Insira o primeiro valor");
        Console.WriteLine("3. Insira a operação");
        Console.WriteLine("4. Insira o segundo valor");
        Console.WriteLine("5. Resultado em mãos!!!");
    }

    public static List<string> historico = new List<string>();

    public static void Historico(string operacao, double num1, double? num2, double resultado)
    {
        
        historico.Add($"{num1} {operacao} {num2} = {resultado}");
    }
    
    public static void MostrarHistorico()
    {   
        Console.WriteLine("Histórico:");
        foreach (var entrada in historico)
            {
                Console.WriteLine(entrada);
            }
    }

    public static void SalvarHistorico()
    {
        File.WriteAllLines("historico.txt", historico);
        Console.WriteLine("Histórico salvo em \\Calculadora\\bin\\Debug\\net9.0 'historico.txt'.");     
    }
    
    public static double Contas(double num1, double num2, string operacao)
    {
        double resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "x":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero!");
                    return double.NaN;
                }
                resultado = num1 / num2;
                break;
            case "q":
                resultado = num1 * num1;
                break;
            case "r":
                resultado = Math.Sqrt(num1);
                break;
            case "^":
                resultado = Math.Pow(num1, num2);
                break;
            case "%":
                resultado = num1 * (num2 / 100);
                break;

        }
        if (operacao == "q" || operacao == "r") Historico(operacao, num1, null, resultado);
        else Historico(operacao, num1, num2, resultado);

        return resultado;
    }

    public static double InserirValor(string operacao)
    {
        if (operacao == "q" || operacao == "r")
            return 0;
        
        while (true)
        {
            Console.WriteLine("Valor:");
            if (double.TryParse(Console.ReadLine(), out double num))
                return num;
            Console.WriteLine("Valor inválido. Digite um número.");
        }
        
        
    }
    public static string InserirOperacao()
    {
        while (true)
            {   
                Console.WriteLine("Operação:");
                string operacao = Console.ReadLine() ?? "";
                if (operacao == "+" || operacao == "-" || operacao == "x"
                || operacao == "/" || operacao == "q" || operacao == "r" || operacao == "^" || operacao == "%")
                    return operacao;
                else
                    Console.WriteLine("Insira uma operação valida segundo o menu");
            }

    }
    public static void Main()
    {
        Console.WriteLine("Calcudora em C#, tenha bom uso!");

        while (true)
        {
            MenuPrincipal();        
            
            string escolha = Console.ReadLine() ?? "";
            switch (escolha)
            {
                case "1":
                    MenuCalculadora();
                
                    string operacao = "";

                    // Primeiro número
                    double num1 = InserirValor(operacao);

                    // Operação
                    operacao = InserirOperacao();

                    // Segundo número
                    double num2 = InserirValor(operacao);

                    double resultado = Contas(num1, num2, operacao);

                    Console.WriteLine($"Resultado: {resultado:F2}");

                    break;
                case "2":
                    MostrarHistorico();
                    break;
                case "3":
                    historico.Clear(); 
                    Console.WriteLine("Histórico apagado com sucesso!");
                    break;
                case "4":
                    SalvarHistorico();
                    break;
                case "5":
                    MenuAjuda();
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

