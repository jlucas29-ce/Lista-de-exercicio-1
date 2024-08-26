/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva Farias 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int moedas, taxa;
        double bonusEve, bonusHa, conver;

        Console.WriteLine("Moedas de Ouro:");
        int.TryParse(Console.ReadLine(), out moedas);

        Console.WriteLine("Taxa de Conversão:");
        int.TryParse(Console.ReadLine(), out taxa);
        Console.WriteLine("Bônus de Evento:");
        double.TryParse(Console.ReadLine(), out bonusEve);


        Console.WriteLine("Bônus de Habilidade:");
        double.TryParse(Console.ReadLine(), out bonusHa);


        conver = ((moedas / taxa) * bonusEve) * bonusHa;

        Console.WriteLine("Cristais obtidos:" + Math.Floor(conver));
        Console.ReadLine();
    }
}

