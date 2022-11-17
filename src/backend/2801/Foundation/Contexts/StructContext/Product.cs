namespace Foundation.Contexts.StructContext;

public struct Product // normalmente usado para transportar dados dentro de um programa.
{
    public string Name { get; set; } // propriedade
    public double Price { get; set; }
    public EProductType Type { get; set; }

    public Product(string name, double price, EProductType type) // construtor usado para inicializar as propriedades.
    {
        // no caso de um struct é obrigatório iniciar todas as propriedades no construtor.
        this.Name = name;
        this.Price = price;
        this.Type = type;
    }

    public override string ToString() // cria uma representação textual de qualquer estrutura da liguagem.
    {
        return $"- Structs ({Type} {Name} : {Price:c2})."; // - Struct (Blush Velvet Matte : $ 25.12).
    }
}

public enum EProductType // permite a estruturação de opções relacionadas a um determinado valor.
{
    Blush, // é possível atribuir um valor de referência a cada opção. (Blush = 0).
    Foundation,
    Powder
}