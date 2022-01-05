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
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    if (tabuleiro.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
