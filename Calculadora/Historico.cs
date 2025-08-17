namespace Calculadora.Historico;

class Historico
{
    // Lista que vai armazenar as operacoes feitas
    public static List<string> registros = new List<string>();
    public static void Adicionar(string operacao, double num1, double? num2, double resultado)
    {
        registros.Add($"{num1} {operacao} {num2} = {resultado}");
    }

    // Função que mostra o historico
    public static void Mostrar()
    {
        Console.WriteLine("Histórico:");
        foreach (var entrada in registros)
        {
            Console.WriteLine(entrada);
        }
    }

    // Funcao que salva um arquivo .txt do historico
    public static void Salvar()
    {
        File.WriteAllLines("historico.txt", registros);
        Console.WriteLine("Histórico salvo em \\Calculadora\\bin\\Debug\\net9.0 'historico.txt'.");
    }

    // Funcao que apaga o historico
    public static void Apagar()
    {
        registros.Clear();
        Console.WriteLine("Histórico apagado com sucesso!");
    }
}
