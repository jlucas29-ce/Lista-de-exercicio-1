/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva farias 
@Data: 19/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {   int vida, aumento, nivel;
    double mult;
        Console.WriteLine("Pontos de Vida Iniciais:");
        int.TryParse(Console.ReadLine(), out vida);
        Console.WriteLine("Aumento por Nível:");
          int.TryParse(Console.ReadLine(), out aumento);
        Console.WriteLine("Nível Alcançado:");
          int.TryParse(Console.ReadLine(), out nivel);

          mult = aumento * nivel + vida;

          Console.WriteLine($"Pontos de Vida Finais:{mult}");
        Console.ReadLine();
    }
}

