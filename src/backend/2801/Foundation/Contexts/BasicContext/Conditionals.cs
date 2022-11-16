namespace Foundation.Contexts.BasicContext;

internal static class Conditionals // estruturas de decisão condicional.
{
    public static string IfElse() //usada quando é necessário uma série de validações distintas.
    {
        short age = 17;
        bool isLegalAge = false;

        if (age >= 18) // expressão com a validação lógica.
            isLegalAge = true;
        else
            isLegalAge = !isLegalAge;

        return "- Conditionals (If/Else).";
    }

    public static string SwitchCase() // usada quando é necessário comparar a mesma variável com várias opções.
    {
        short status = 1;
        string message = string.Empty;

        switch (status) // variável usada como base para a comparação.
        {
            case 1: message = "Ativo"; break; // o break informa que não é mais necessário continuar validando.
            case 2: message = "Suspenso"; break;
            default: message = "Inativo"; break; // o default é a opção padrão caso não "caia" em nenhum case.
        }

        return "- Conditionals (Switch/Case).";
    }
}
