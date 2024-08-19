/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
• Comando: Crie um programa que receba o

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva farias 
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {

        int idade, nivel;
        string nome, classe, raca;

        Console.WriteLine("Informe a seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Informe a sua idade: ");
        int.TryParse(Console.ReadLine(), out idade);
        
        Console.WriteLine("Informe seu nível: ");
        int.TryParse(Console.ReadLine(), out nivel);

        Console.WriteLine("Informe sua classe: ");
        classe = Console.ReadLine();

        Console.WriteLine("Informe a sua raça:");
        raca = Console.ReadLine();

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"idade: {idade}");
        Console.WriteLine($"Nivel: {nivel}");
        Console.WriteLine($"Classe: {classe}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Raça: {raca}");
        Console.ReadLine();
    }
}