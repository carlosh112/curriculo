public class Produto
{
    //Atributo
    private string marca;
    public int preco;

    //Propriedade



    //Metodo Construtor
    public Produto()
    {
    }

    //Metodo da Instancia
    public int CalcularNovoPrecoComDesconto(int percentual)
    {
        return preco * percentual;
    }

    
}

//radmin vpn






public static void main()
{
    Produto carro = new Produto();
    carro.marca = "Honda"
    carro.preco = 200;

    int novoPreco = CalcularNovoPrecoComDesconto(0,1);
    Console.Write(novoPreco);
}

//instancia ou objeto => honda
//classe => modelo do tipo do dado





