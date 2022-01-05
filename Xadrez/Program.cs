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
            TabuleiroClass tabuleiro = new TabuleiroClass(8, 8);

            tabuleiro.ColocarPeca(new Torre(Cor.Branca, tabuleiro), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(Cor.Branca, tabuleiro), new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(Cor.Branca, tabuleiro), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadKey();
        }
    }
}
