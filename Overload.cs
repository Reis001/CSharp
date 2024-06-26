public class Personagem {
    private string nome;
    private string nacao;
    private int idade;
    
    public Personagem(string nome, string nacao, int idade){
        Nome = nome;
        Nacao = nacao;
        Idade = idade;
    }

    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public string Nacao {
        get { return nacao; }
        set { nacao = value; }
    }
    public int Idade {
        get { return idade; }
        set { idade = value; }
    }
     public virtual void Atacar() {
        Console.WriteLine("Ataque básico!");
    }
    public virtual void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial: " + habilidade);
         }
}

public class Guerreiro : Personagem {
    private string espada;

    public Guerreiro(string nome, string nacao, int idade, string espada ) : base(nome, nacao, idade) {
        Espada = espada;
    }

    public string Espada{
        get { return espada; }
        set { espada = value; }
    }
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial: " + habilidade);
         }
}

public class Mago : Personagem {
    private string grimorio;

    public Mago(string nome, string nacao, int idade, string grimorio) : base(nome, nacao, idade) {
        Grimorio = grimorio;
    }

    public string Grimorio{
        get { return grimorio; }
        set { grimorio = value; }
    }
    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial: " + habilidade);
         }
}

public class Pescador : Personagem {
    private string vara;

    public Pescador(string nome, string nacao, int idade, string vara) : base(nome, nacao, idade) {
        Vara = vara;
    }

    public string Vara{
        get { return vara; }
        set { vara = value; }
    }
    public void Atacar() {
        Console.WriteLine("Pescador lhe da uma varada!");
    }
    public void Atacar(string habilidade) {
        Console.WriteLine("Ataque especial: " + habilidade);
         }
}
public class Program {
        public static void main (String[] args){

            Guerreiro guerreiro = new Guerreiro("Anjo Caido N", "Nação da espada", 45000000000, "Espada canceladora de cpf");
            guerreiro.Atacar();
            guerreiro.Atacar("Investida");

            Mago mago = new Mago("Lucas", "Nação de Hogwarts", 18, "Grimório do wingardium leviosa");
            mago.Atacar();
            mago.Atacar("Levitação");

            Pescador pescador = new Pescador("Jax Pescador", "Nação do Lol", 85 "Vara do sapo verde");
            pescador.Atacar();
            pescador.Atacar("Pescado");
        }
}

