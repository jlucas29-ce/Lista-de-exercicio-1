/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva Farias 
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {   double velocidade, tempo, multclima, multEsta, total;

        Console.WriteLine("Velocidade:");
        double.TryParse(Console.ReadLine(), out velocidade);
        
        Console.WriteLine("Tempo:");
        double.TryParse(Console.ReadLine(), out tempo);

        Console.WriteLine("Multiplicador Climático:");
        double.TryParse(Console.ReadLine(), out multclima);

        Console.WriteLine("Multiplicador Estado do Veículo:");
         double.TryParse(Console.ReadLine(), out multEsta);

        total = (velocidade * tempo * multclima * multEsta);

        Console.WriteLine($"Distância Percorrida:{total}");
        Console.ReadLine();
    }
}
