/*-------------------------------------------------------------------
Questão 9: Comparação de Poder de Ataque
* Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em
sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos
e pelo tipo da arma.
* Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de
Comando: habilidades, um modificador de crítico, e um modificador para o tipo da arma. O
programa deve calcular o total de ataque do personagem


@Lista: 01 - Lógica de Programação
@Autor: João Lucas Saraiva Farias 
@Data: 21/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    public static void Main()
    {   
        double forca, poderdaArma, bonusdeHabilidade, modificadorCritico, ModificadorTipodaArma, soma;
        
            
        Console.WriteLine ("Informe a força:");
        double.TryParse(Console.ReadLine(), out forca);
        
        
        Console.WriteLine ("Informe o poder da arma :");
        double.TryParse(Console.ReadLine(), out poderdaArma);
        
        Console.WriteLine ("Informe o bônus de habilidade:");
        double.TryParse(Console.ReadLine(), out bonusdeHabilidade);
        
        Console.WriteLine ("Informe o modificador crítico:");
        double.TryParse(Console.ReadLine(), out modificadorCritico);
         Console.WriteLine ("Informe o modificador tipo de arma:");
        double.TryParse(Console.ReadLine(), out ModificadorTipodaArma);
        
        
        soma = (poderdaArma * bonusdeHabilidade * modificadorCritico * ModificadorTipodaArma) + forca;
        
        Console.WriteLine($"Total de ataque:{soma}");
        
    }
}