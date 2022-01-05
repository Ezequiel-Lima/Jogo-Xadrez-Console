using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(TabuleiroClass tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linha; i++)
            {
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    if (tabuleiro.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(tabuleiro.Peca(i,j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
