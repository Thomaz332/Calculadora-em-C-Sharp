namespace Calculadora.Menus;

class Menus
{
    // Dicionario das operacoes disponiveis
    public static Dictionary<string, string> OperacoesDisponiveis = new()
    {
        {"+", "Soma"},
        {"-", "Subtração"},
        {"x", "Multiplicação"},
        {"/", "Divisão"},
        {"^", "Potência"},
        {"%", "Porcentagem"},
        {"q", "Quadrado"},
        {"r", "Raiz Quadrada"},
    };

    // Menu Principal do Programa
    public static void MenuPrincipal()
    {
        Console.WriteLine("\n1 - Nova Operação");
        Console.WriteLine("2 - Ver Histórico");
        Console.WriteLine("3 - Apagar Histórico");
        Console.WriteLine("4 - Salvar Histórico");
        Console.WriteLine("5 - Ajuda");
        Console.WriteLine("6 - Sair");
    }

    // Menu da Calculadora
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

    // Menu de Operacoes disponiveis
    public static void MenuOperacoes()
    {
        foreach (var op in OperacoesDisponiveis)
            Console.WriteLine($"{op.Key} : {op.Value}");
    }
}