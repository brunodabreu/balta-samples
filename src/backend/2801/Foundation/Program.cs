// importação de classes e bibliotecas.
using Foundation.Contexts.BasicContext;
using Foundation.Contexts.StructContext;

namespace Foundation; // divisão lógica das classes do programa.

internal class Program // definição e escopo da classe.
{
    private static void Main(string[] args) // método principal de execução do console.
    {
        Console.Clear();

        Console.WriteLine(Types.Variables()); // variáveis.
        Console.WriteLine(Types.Constants()); // constantes.

        Console.WriteLine();
        Console.WriteLine(Conversions.Implicit()); // conversão implícita.
        Console.WriteLine(Conversions.Explicit()); // conversão explícita.

        Console.WriteLine();
        Console.WriteLine(Operators.Attribution()); // operadores de atribuição.
        Console.WriteLine(Operators.Arithmetic()); // operadores matemáticos.
        Console.WriteLine(Operators.Logical()); // operadores lógicos.

        Console.WriteLine();
        Console.WriteLine(Conditionals.IfElse()); // estrutura condicional if/else.
        Console.WriteLine(Conditionals.SwitchCase()); // estrutura condicional switch/case.

        Console.WriteLine();
        Console.WriteLine(Repetitions.LoopFor()); // estrutura de repetição for.
        Console.WriteLine(Repetitions.LoopWhile()); // estrutura de repetição while.
        Console.WriteLine(Repetitions.LoopDoWhile()); // estrutura de repetição do/while.

        Console.WriteLine();
        Console.WriteLine(new Product("Velvet Matte", 25.12, EProductType.Blush)); // structs e enums.
    }
}
