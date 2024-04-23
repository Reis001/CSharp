using System;

public abstract class Automovel {
    private string nome;
    private int vida;

    public Automovel(string nome, int vida) {
        this.nome = nome;
        this.vida = vida;
    }

    // Getter para o nome
    public string GetNome(){
        return nome;
    }

    // Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }

    // Getter para a vida
    public int GetVida(){
        return vida;
    }

    // Setter para a vida
    public void SetVida(int vida){
        this.vida = vida;
    }

    public abstract void Ligar(); // Método abstrato

    public abstract void Dirigir(); // Método abstrato

    public void ReceberDano(int dano) { // Método concreto
        Vida -= dano;
        Console.WriteLine($"Você bateu, recebeu {dano} de dano e agora tem {Vida} de vida.");
        if (Vida <= 0) {
            Morrer();
        }
    }

    public void Morrer() {
        Console.WriteLine($"{Nome} explodiu!");
    }
}

public class Carro : Automovel {
    public Carro(string nome, int vida) : base(nome, vida) {}

    public override void Dirigir() {
        Console.WriteLine($"{GetNome()} acelerou");
    }
    public override void Ligar() {
        Console.WriteLine($"{GetNome()} deu partida!");
    }
}

public class Moto : Automovel {
    public Moto(string nome, int vida) : base(nome, vida) {}

    public override void Dirigir() {
        Console.WriteLine($"{GetNome()} acelerou");
    }

    public override void Ligar() {
        Console.WriteLine($"{GetNome()} deu partida!");
    }
}

public class Program {
    public static void Main(string[] args) {
        Carro carro = new Carro("Fusca", 100);
        carro.Dirigir();
        carro.ReceberDano(20);
        carro.Morrer();
        carro.Ligar();

        Moto moto = new Moto("Harley", 80);
        moto.Dirigir();
        moto.ReceberDano(50);
        moto.Morrer();
        moto.Ligar();
    }
}
