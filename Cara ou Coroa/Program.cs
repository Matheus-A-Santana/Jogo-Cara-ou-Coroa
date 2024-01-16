namespace Cara_ou_Coroa;
using Cara_ou_Coroa.Models;

class Program
{
    static void Main(string[] args)
    {
        CaraCoroa Jogo = new CaraCoroa();
        bool loop = true;
        while(loop)
        {
            Console.WriteLine("\tJogo Cara ou Coroa\n" +
            "\t1 - Cara\n"+
            "\t2 - Coroa\n"+
            "\t0 - Sair");
            switch(Convert.ToInt64(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Selecionado Cara\n"+
                    "\n\n\tJogando a moeda... ");
                    Thread.Sleep(3000);
                    Console.WriteLine(Jogo.Moeda("Cara"));
                    break;
                case 2:
                    Console.WriteLine("Selecionado Coroa\n"+
                    "\n\n\tJogando a moeda... ");
                    Thread.Sleep(3000);
                    Console.WriteLine(Jogo.Moeda("Coroa"));
                    break;
                case 0:
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Selecionou um número invalido.\nPor Favor Selecione um número válido!");
                    break;
            }
        }
    }
}
