﻿/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
• Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva Farias 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int md1, md2, md3, md4, md5, soma;
        Console.WriteLine("Moedas coletadas 1:");
        int.TryParse(Console.ReadLine(), out md1);

        Console.WriteLine("Moedas coletadas 2:");
        int.TryParse(Console.ReadLine(), out md2);
        
        Console.WriteLine("Moedas coletadas 3:");
        int.TryParse(Console.ReadLine(), out md3);
        
        Console.WriteLine("Moedas coletadas 4:");
        int.TryParse(Console.ReadLine(), out md4);
        
        Console.WriteLine("Moedas coletadas 5:");
        int.TryParse(Console.ReadLine(), out md5);
        
        soma = (md1 + md2 + md3 + md4 + md5);

        Console.WriteLine($"Total de moedas {soma}");
        
        Console.ReadLine();
    }
}
