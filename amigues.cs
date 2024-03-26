using System;

public class Sesquitos {
    //atributos
    private string nome;
    private string cor;
    private int idade;
    private double altura;
    private char genero;

    //construtor
    public Sesquitos(string nome, string cor, int idade, double altura, char genero){
        this.nome = nome;
        this.cor = cor;
        this.idade = idade;
        this.altura = altura;
        this.genero = genero;
    }

    public void infoSesquitos(){
        Console.WriteLine($"Nome: {nome}, idade: {idade}, altura: {altura}, genero: {genero}");
    }
    public void correr() {
        Console.WriteLine("Correndo.");
    }
    public void pular() {
        Console.WriteLine("Pulando.");
    }
}

public class Barriguinha : Sesquitos {

    public Barriguinha(){
        this.nome = "Barriguinha";
        this.cor = "Branco";
        this.idade = 17;
        this.altura = 1.75;
        this.genero = "M";

        public void Peidar(){
            Console.WriteLine("hummmm, peidaro")
        }
        
    }
}

public class David : Sesquitos {

    public David(){
        this.nome = "David";
        this.cor = "light skin";
        this.idade = 17;
        this.altura = 1.80,05;
        this.genero = "M";

        public void Vandalizar(){
            Console.WriteLine("ahhhh mano!!!")
        }
        
    }
}

class Program {
    static void Main(string[] args){
        Barriguinha barriguinha = new Barriguinha();
        David david = new David();

        Console.WriteLine($"Nome: {barriguinha.Nome}, Cor: {barriguinha.Cor}, Idade: {barriguinha.Idade}, Altura: {barriguinha.Altura}, Gênero: {barriguinha.Genero}");

        barriguinha.Correr();
        barriguinha.Pular();
        barriguinha.Peidar();

        Console.WriteLine();
        Console.WriteLine($"Nome: {david.Nome}, Cor: {david.Cor}, Idade: {david.Idade}, Altura: {david.Altura}, Gênero: {david.Genero}");

        david.Correr();
        david.Pular();
        david.Vandalizar();

    }
}