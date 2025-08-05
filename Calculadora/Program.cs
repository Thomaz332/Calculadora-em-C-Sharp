using System;


class Program
{   
    static void Menu()
    {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔═════════════════╗");
    Console.WriteLine("║   | q  | r | /  ║");
    Console.WriteLine("║ 7 | 8  | 9 | x  ║");
    Console.WriteLine("║ 4 | 5  | 6 | -  ║");
    Console.WriteLine("║ 1 | 2  | 3 | +  ║");
    Console.WriteLine("║   | 0  | . | =  ║");
    Console.WriteLine("╚═════════════════╝");
    Console.ResetColor();
    }

        static void Main()
    {
        Console.WriteLine("Calcudora em C#, tenha bom uso!");

        Menu();

        while (true)
        {
            // Primeiro número
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada: ");

            // Operação
            string operacao = "";
            while (true)
            {
                operacao = Console.ReadLine() ?? "";
                if (operacao == "+" || operacao == "-" || operacao == "x"
                || operacao == "/" || operacao == "q" || operacao == "r")
                    break;
                else
                    Console.WriteLine("Insira uma operação valida segundo o menu");
            }

            double num2 = 0;

            // Segundo número
            if (operacao != "q" && operacao != "r")
            {
                Console.WriteLine("Digite o segundo número");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            double resultado = 0;

            // Contas
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
                    resultado = num1 / num2;
                    break;
                case "q":
                    resultado = num1 * num1;
                    break;
                case "r":
                    resultado = Math.Sqrt(num1);
                    break;
            }
            Console.WriteLine(resultado);

            Console.WriteLine("Se deseja continuar digite qualquer valor, caso contrario digite 1");
            string escolha = Console.ReadLine() ?? "";
            if (escolha == "1")
                Console.WriteLine("Obrigado por utilizar o programa!");
                break;
            
        }
    }
}
