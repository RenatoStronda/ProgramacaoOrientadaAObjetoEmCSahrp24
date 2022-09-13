// See https://aka.ms/new-console-template for more information
﻿using System;
using Classes;
namespace pessoA{
    class Program {
    public static void Main (string[] args) {
    pessoa p = new pessoa("Renato", 27);
    Console.WriteLine(p.getNome());
    Console.WriteLine(p.getIdade());
    Console.WriteLine("Sua Idade De Aniversário É: ");
    Console.WriteLine(p.fazerAniversario());
  }
}
}
/*2- Crie uma classe Pessoa que possui dois atributos:  idade : int e nome : string. 
Implemente o método fazerAniversario() que incrementa o atributo idade em passo 1. 
Crie um método construtor que possui como parâmetro o nome : string e injete o parâmetro no atributo nome, 
e atribua o valor 0 ao atributi idade dentro do método construtor. 
Implemente o método getNome() e getIdade() que retorna o valores dos respectivos atributos nome, idade*/