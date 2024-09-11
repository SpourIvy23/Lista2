/*-------------------------------------------------------------------
Questão 1: Seleção de Armadura
• Contextualização: Em um jogo de RPG, cada classe de personagem (Guerreiro, Arqueiro, Mago) 
possui requisitos diferentes para a escolha da armadura ideal. A armadura é considerada ideal 
se a defesa oferecida for alta o suficiente para a classe e se a penalidade de agilidade for 
aceitável.
• Comando:
Crie um programa que receba a classe do personagem, o valor de defesa da armadura e a 
penalidade de agilidade. O programa deve informar se a armadura é adequada ou não para a 
classe.
• Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
• Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
• Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.
@Lista: 02 - Condicionais
@Autor: Murilo Pires
@Data: 25/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        int defesaIdeal = 0, penalidadeIdeal = 0, penalidade, defesa, classe, funciona = 0;

        System.Console.WriteLine("Escolha sua classe \n" +
        "1-Guerreiro \n" +
        "2-Arqueiro \n" +
        "3-Mago \n" +
        "Escolha: ");
        int.TryParse(Console.ReadLine(), out classe);

        switch (classe)
        {
            case 1:
                defesaIdeal = 50;
                penalidadeIdeal = 20;
                break;
            case 2:
                defesaIdeal = 30;
                penalidadeIdeal = 10;
                break;
            case 3:
                defesaIdeal = 20;
                penalidadeIdeal = 40;
                break;

        }
        System.Console.WriteLine("Escreva sua defesa");
        int.TryParse(Console.ReadLine(), out defesa);
        System.Console.WriteLine("Escreva sua penalidade de agilidade");
        int.TryParse(Console.ReadLine(), out penalidade);

        Console.Clear();
        

        if(defesa > defesaIdeal)
        {
        
            funciona++;
        }

        if(penalidade < penalidadeIdeal)
        {
            funciona++;
        }
        
        if(funciona == 2)
        {
            System.Console.WriteLine("Sua armadura é adequada");
        }   
        else
        {
            System.Console.WriteLine("Sua armadura não é adequada");
        }

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        

    }
}
