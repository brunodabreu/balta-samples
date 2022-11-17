namespace Foundation.Contexts.BasicContext;

internal static class Operators // operadores de atribuição, comparação e matemáticos.
{
    public static string Arithmetic() // usado para executar operações e expressões matemáticas.
    {
        int sum = 20 + 20; // operação de soma.
        int subtraction = 20 - 10; // operação de subtração.
        int multiplication = 20 * 20; // operação de multiplicação.
        int division = 20 / 5;  // operação de divisão.

        var result = sum + (division * multiplication) / subtraction; // expressão matemática.

        return "- Operators (Arithmetic).";
    }

    public static string Attribution() // usado para atribuir valor a uma propriedade (variável ou constante).
    {
        int intValue = 5; // inicia a variável atribuindo um determinado valor.
        intValue += 5; // agrega um determinado valor ao valor original da variável.

        return "- Operators (Attribution).";
    }

    public static string Logical() // usado para executar comparações lógicas entre diferentes valores.
    {
        // as comparações sempre retornam um valor booleano (verdadeiro ou falso).
        bool isEqual = (1 == 1);
        bool isDifferent = (1 != 1);
        bool isGreaterThan = (1 > 2); // também existe o maior ou igual (>=).
        bool isLessThan = (1 < 2); // também existe o menor ou igual (<=).

        bool andOperator = isEqual && isLessThan; // && (AND) - ambos os valores devem ser verdadeiros.
        bool orOperator = isDifferent || isGreaterThan; // || (OR) - ao menos um dos valores deve ser verdadeiro.
        bool notOperator = !orOperator; // ! (NOT) - inverte o resultado lógico, original, da expressão.

        return "- Operators (Logical).";
    }
}
