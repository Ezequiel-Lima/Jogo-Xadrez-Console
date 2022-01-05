using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.JogoXadrez;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                Tela.ImprimirTabuleiro(partidaDeXadrez.Tabuleiro);
            }
            catch (TabuleiroException error)
            {
                Console.WriteLine($"{error.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
