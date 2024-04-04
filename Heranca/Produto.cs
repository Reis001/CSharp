public  class Produto {
    private String nome;
    private Decimal preco;
    private String descricao;=
    private String categoria;

    public Produto(string nome, decimal preco, string descricao, string categoria){
        Nome = nome;
        Preco = preco;
        Descricao = descricao;
        Categoria = categoria
    }

    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public decimal Preco {
        get { return preco; }
        set { preco = value; }
    }
    public string Descricao {
        get { return descricao; }
        set { descricao = value; }
    }
    public string Categoria {
        get { return categoria; }
        set { categoria = value; }
    }
}

public class ConsoleGame : Produto {
    private int capacidadeArmazenamento;

    public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int capacidadeArmazenamento ) : base(nome, preco, descricao, categoria) {
        CapacidadeArmazenamento = capacidadearmAzenamento;
    }

    public string CapacidadeArmazenamento{
        get { return capacidadeArmazenamento; }
        set { capacidadeArmazenamento = value; }
    }
}

public class Jogo : Produto {
    private string genero;

    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero ) : base(nome, preco, descricao, categoria) {
        Genero = genero;
    }

    public string Genero{
        get { return genero; }
        set { genero = value; }
    }
}

public class Acessorio : Produto {
    private string tipo;

    public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo ) : base(nome, preco, descricao, categoria) {
        Tipo = tipo;
    }

    public string Tipo{
        get { return tipo; }
        set { tipo = value; }
    }
}

public class Colecionavel : Produto {
    private bool edicaoLimitada;

    public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada ) : base(nome, preco, descricao, categoria) {
        EdicaoLimitada = edicaoLimitada;
    }

    public string EdicaoLimitada{
        get { return edicaoLimitada; }
        set { edicaoLimitada = value; }
    }
}