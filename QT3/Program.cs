/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva Farias 
@Data: 16/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {   
        int vidaIni, dano, bonus, soma, mult, final;
        double modificadorEq, modificadorHa;

        Console.WriteLine("Vida Inicial:");
        int.TryParse(Console.ReadLine(), out vidaIni);

        Console.WriteLine("Dano Recebido:");
         int.TryParse(Console.ReadLine(), out dano);
        
        Console.WriteLine("Bônus de Regeneração:");
         int.TryParse(Console.ReadLine(), out bonus);
        
        Console.WriteLine("Modificador Equipamentos:");
         double.TryParse(Console.ReadLine(), out modificadorEq);
        
        Console.WriteLine("Modificador Habilidades:");
        double.TryParse(Console.ReadLine(), out modificadorHa);

        soma = vidaIni - dano + bonus;
        mult = modificadorEq * soma 
        

        final = mult + soma
        Console.ReadLine();
    }
}