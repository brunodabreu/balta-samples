namespace Foundation.Contexts.BasicContext;

internal static class Conversions // conversões explícita e conversões implícitas.
{
    public static string Explicit() // validada em tempo de execução e pode perder precisão.
    {
        double doubleValue = 1276.23; // valor origem.
        int intValue = (int)doubleValue; // método de conversão.
        intValue = Convert.ToInt32(intValue); // método de conversão.
        intValue = int.Parse("1276"); // método de conversão.

        return "- Conversions (Explicit).";
    }

    public static string Implicit() // validada em tempo de compilação e não perde precisão.
    {
        int intValue = 1276; // valor origem.
        double doubleValue = intValue; // todos os valores do tipo origem cabem no tipo destino.

        return "- Conversions (Implicit).";
    }
}
