/*-------------------------------------------------------------------
Questão 7: Cálculo de Nível do Jogador
• Contextualização: Um jogador ganha uma certa quantidade de experiência (XP) ao completar
missões. O nível do jogador é determinado pelo total de XP dividido por uma constante de nível
e ajustado por bônus.
• Comando: Crie um programa que receba a quantidade de XP acumulado, a constante de nível,
o bônus de nível, e dois multiplicadores (um para eventos especiais e outro para equipamentos),
e calcule o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva Farias 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {   int xp, constante, bonus, div;
    double mult1, mult2;

        Console.WriteLine("Xp acumulado:");
int.TryParse(Console.ReadLine(), out xp);

         Console.WriteLine("Constante de Nível:");
int.TryParse(Console.ReadLine(), out constante);

          Console.WriteLine("Bônus de Nível:");
         int.TryParse(Console.ReadLine(), out bonus);
         
           Console.WriteLine("Multiplicador Eventos:");
         double.TryParse(Console.ReadLine(), out mult1);
         
           Console.WriteLine("Multiplicador Equipamentos:");
           double.TryParse(Console.ReadLine(), out mult1);

div = (xp / constante) + 1;
Console.WriteLine($"Nível do Jogador:{div}");
        Console.ReadLine();
    }
}

