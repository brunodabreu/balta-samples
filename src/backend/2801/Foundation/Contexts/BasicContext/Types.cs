namespace Foundation.Contexts.BasicContext;

internal static class Types // tipos primitivos, variáveis e constantes.
{
    public static string Constants() // armazenam um valor que não pode ter seu conteúdo alterado.
    {
        const string Message = "- Types (Constants)."; // uma vez definida não pode ser alterada.
        return Message;
    }

    public static string Variables() // armazenam um valor que pode ter o seu conteúdo alterado.
    {
        var message = string.Empty;
        message = "- Types (Variables)."; // alteração do conteúdo da variável.

        return message;
    }
}
