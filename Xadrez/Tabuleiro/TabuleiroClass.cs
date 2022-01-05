using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Tabuleiro
{
    internal class TabuleiroClass
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] Pecas { get; set; }

        public TabuleiroClass(int linha, int colunas)
        {
            Linha = linha;
            Coluna = colunas;
            Pecas = new Peca[Linha, Coluna];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public void ColocarPeca(Peca peca, Posicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }
    }
}
