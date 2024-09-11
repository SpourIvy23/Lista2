
using System;

class Program
{
    static void Main()
    {
        int inimigos, pontos = 0, tempo, tomou;
        const int maximo = 100;
        bool critico = false;

        System.Console.WriteLine("Quantos inimigos foram derrotados?");
        int.TryParse(Console.ReadLine(), out inimigos);

        pontos = 10 * inimigos;

        System.Console.WriteLine("Quantos minutos levou para derrotar eles?");
        int.TryParse(Console.ReadLine(), out tempo);
        if(tempo > 5)
        {
            pontos-=10;

        }

        System.Console.WriteLine("Tomou critico? \n" +
        "1-Sim \n" +
        "2-Não");
        int.TryParse(Console.ReadLine(), out tomou);
        switch(tomou)
        {
            case 1: critico = true;
            break;
            case 2: critico = false;
            break;
        }
        if(critico == true)
        {
            pontos-=10;

        }

        if(pontos > maximo)
        {
            pontos=maximo;
        }

        System.Console.WriteLine("Você alcançou " + pontos + " pontos!");

        System.Console.WriteLine("Aperte ENTER para fechar");
        Console.ReadLine();
        
        
    }
}
