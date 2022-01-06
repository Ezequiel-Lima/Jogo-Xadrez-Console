using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimento { get; protected set; }
        public TabuleiroClass Tabuleiro { get; protected set; }

        public Peca(Cor cor, TabuleiroClass tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimento = 0;
        }

        public void IncrementarQuantidadeMovimentos()
        {
            QuantidadeMovimento++;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for (int i = 0; i < Tabuleiro.Linha; i++)
            {
                for (int j = 0; j < Tabuleiro.Coluna; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
