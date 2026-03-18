using System;
using System.Security.Cryptography.X509Certificates;

class Colaborador : Pessoa
{
    //Atributo

    private double salario;

    //Construtor

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;


        dadosPessoa();
        dadosColaborador();
    }

    //Métodos
    private void dadosColaborador()
    {
        Console.WriteLine("Salário é: " + salario);
    }
}