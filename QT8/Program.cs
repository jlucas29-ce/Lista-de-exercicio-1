/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva Farias 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {   
        int forca, agi, inte, destre, vita, soma;

        Console.WriteLine("Força: ");
 int.TryParse(Console.ReadLine(), out forca);

        Console.WriteLine("Agilidade: ");
         int.TryParse(Console.ReadLine(), out agi);

        Console.WriteLine("Inteligência: ");
         int.TryParse(Console.ReadLine(), out inte);

        Console.WriteLine("Destreza: ");
         int.TryParse(Console.ReadLine(), out destre);

         Console.WriteLine("Vitalidade: ");
         int.TryParse(Console.ReadLine(), out vita);

         soma = forca + agi + inte + destre + vita;

         Console.WriteLine($"Total de pontos:{soma}");
        Console.ReadLine();
    }
}


