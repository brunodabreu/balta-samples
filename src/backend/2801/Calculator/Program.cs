namespace Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Start(); // inicializa as instruções da calculadora.
    }

    private static void Start()
    {
        PrintMenu();

        short operation = short.Parse(Console.ReadLine()); // conversão explícita de uma string para um short.

        if (operation == 0)
            Environment.Exit(0); // finaliza a execução do console manualmente.

        double result = 0;
        double firstValue = GetUserInput("Primeiro valor: "); // primeiro valor da operação matemática.
        double secondValue = GetUserInput("Segundo valor: "); // segundo valor da operação matemática.

        switch (operation) // verifica qual a operação selecionada e executa a operação matemática correspondente.
        {
            case 1: result = firstValue + secondValue; break; // soma.
            case 2: result = firstValue - secondValue; break; // substração.
            case 3: result = firstValue * secondValue; break; // multiplicação.
            case 4: result = firstValue / secondValue; break; // divisão.
            default: break;
        }

        Console.WriteLine();
        Console.Write($"O resultado da operação é: {result}"); // interpolação permite criar strings dinâmicas.
        Console.ReadKey(); // aguarda o usuário apertar alguma tecla para continuar a execução.

        Start(); // chama de forma recursiva o próprio método até que o usuário opte por encerrar.
    }

    private static double GetUserInput(string message) // método para receber um valor double do usuário via console.
    {
        double userInputValue = 0;

        Console.Write(message);
        double.TryParse(Console.ReadLine(), out userInputValue); // caso a conversão seja válida, atribui o valor à variável.
        
        return userInputValue;
    }

    private static void PrintMenu() // printa no console o menu com as operações disponíveis.
    {
        Console.Clear();
        Console.WriteLine("1 - Soma.");
        Console.WriteLine("2 - Subtração.");
        Console.WriteLine("3 - Multiplicação.");
        Console.WriteLine("4 - Divisão.");
        Console.WriteLine("0 - Sair.");

        Console.WriteLine();
        Console.Write("Escolha a operação matemática: ");
    }
}
