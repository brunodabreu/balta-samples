namespace Foundation.Contexts.BasicContext;

internal static class Repetitions // estruturas e laços de repetição de instruções.
{
    public static string LoopDoWhile() // usado quando se tem noção prévia da quantidade de iterações.
    {
        int counter = 6;
        double value = 1;

        do // as iterações são executadas pelo menos uma vez.
        {
            value = (counter * 6) * (counter / 2);
        } while (counter <= 5); // a validação acontece no final do laço.

        return "- Repetitions (DoWhile).";
    }

    public static string LoopFor() // usado quando se tem noção prévia da quantidade de iterações.
    {
        int counter = 5;
        double value = 1;

        for (int i = 0; i < counter; i++) // a primeira iteração depende da validação inicial.
        {
            if (i > 0) value *= i;
        }

        return "- Repetitions (For).";
    }

    public static string LoopWhile() // usado quando não se tem noção prévia da quantidade de iterações.
    {
        int counter = 1;
        bool repeat = true;
        double value = 1;

        while (repeat) // as iterações dependem de uma validação alterada dentro do laço.
        {
            if (counter > 0) value *= counter; // uma única instrução pode ficar na mesma linha.
            counter++;

            if (value > 100) repeat = false; // alteração da validação do laço de repetição.
        }

        return "- Repetitions (While).";
    }    
}
