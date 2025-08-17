namespace Calculadora.Contas;

using Calculadora.Menus;
using Calculadora.Historico;

class Contas
{
    // Função para calcular as operações
    public static double Operacoes(double num1, double num2, string operacao)
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
        if (operacao == "q" || operacao == "r") Historico.Adicionar(operacao, num1, null, resultado);
        else Historico.Adicionar(operacao, num1, num2, resultado);

        return resultado;
    }

    // Função para inserir os valores
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

    // Função para inserir a operacao
    public static string InserirOperacao()
    {
        while (true)
        {
            Console.WriteLine("Operação:");
            string operacao = Console.ReadLine() ?? "";
            if (Menus.OperacoesDisponiveis.ContainsKey(operacao))
                return operacao;
            else
                Console.WriteLine("Insira uma operação valida segundo o menu");
        }
    }
}