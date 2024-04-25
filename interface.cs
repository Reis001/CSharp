using System;

interface IAtaque {
    void Atacar();
}

public abstract class Heroi {
    public string nome;

    public Heroi(string nome) {
        this.nome = nome;
    }

    public void AplicouDano(int danoTotal) { // Método concreto
        Console.WriteLine($"{nome} aplicou {danoTotal} de dano");
    }

    // Getter para o nome
    public string GetNome() {
        return nome;
    }

    // Setter para o nome
    public void SetNome(string nome) {
        this.nome = nome;
    }

    // Método abstrato para o ataque especial
    public abstract int Especial();
}

public class Guerreiro : Heroi, IAtaque {
    public Guerreiro(string nome) : base(nome) {}

    public override int Especial() {
        return 40; // Dano do ataque especial do Guerreiro
    }

    public void Atacar() {
        int danoBase = 10; // Defina o dano base do Guerreiro
        int danoEspecial = Especial();
        int danoTotal = danoBase + danoEspecial;
        Console.WriteLine($"{GetNome()} usou ataque base, causando {danoBase} de dano");
        Console.WriteLine($"{GetNome()} usou fúria de guerreiro, causando {danoEspecial} de dano");
        AplicouDano(danoTotal); // Chama o método AplicouDano passando o dano total
    }
}

public class Mago : Heroi, IAtaque {
    public Mago(string nome) : base(nome) {}

    public override int Especial() {
        return 35; // Dano do ataque especial do Mago
    }

    public void Atacar() {
        int danoBase = 12; // Defina o dano base do Mago
        int danoEspecial = Especial();
        int danoTotal = danoBase + danoEspecial;
        Console.WriteLine($"{GetNome()} usou ataque base, causando {danoBase} de dano");
        Console.WriteLine($"{GetNome()} usou tempestade de raios, causando {danoEspecial} de dano");
        AplicouDano(danoTotal); // Chama o método AplicouDano passando o dano total
    }
}

public class Arqueiro : Heroi, IAtaque {
    public Arqueiro(string nome) : base(nome) {}

    public override int Especial() {
        return 37; // Dano do ataque especial do Arqueiro
    }

    public void Atacar() {
        int danoBase = 11; // Defina o dano base do Arqueiro
        int danoEspecial = Especial();
        int danoTotal = danoBase + danoEspecial;
        Console.WriteLine($"{GetNome()} usou ataque base, causando {danoBase} de dano");
        Console.WriteLine($"{GetNome()} usou flecha perfurante, causando {danoEspecial} de dano");
        AplicouDano(danoTotal); // Chama o método AplicouDano passando o dano total
    }
}

public class Program {
    public static void Main(string[] args) {
        Guerreiro guerreiro = new Guerreiro("Adamastor");
        guerreiro.Atacar(); // Chamada do método Atacar

        Mago mago = new Mago("Colombo");
        mago.Atacar(); // Chamada do método Atacar

        Arqueiro arqueiro = new Arqueiro("Roberson");
        arqueiro.Atacar(); // Chamada do método Atacar
    }
}