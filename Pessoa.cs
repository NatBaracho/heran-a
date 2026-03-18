using System;

class Pessoa
{
    // Atributo 
    protected string? nome;
    protected int idade;

    //Métodos git 
    protected void dadosPessoa()
    {
        Console.WriteLine("Nome:" + this.nome);
        Console.WriteLine("Idade: "+ this.idade);
    }

}