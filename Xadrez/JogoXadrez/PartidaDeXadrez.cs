using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez.JogoXadrez
{
    internal class PartidaDeXadrez
    {
        public TabuleiroClass Tabuleiro { get; private set; }
        private int Turno { get; set; }
        private Cor JogadorAtual { get; set; }

        public PartidaDeXadrez()
        {
            Tabuleiro = new TabuleiroClass(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tabuleiro.RetirarPeca(origem);
            peca.IncrementarQuantidadeMovimento();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.ColocarPeca(peca, destino);
        }

        private void ColocarPecas()
        {
            Tabuleiro.ColocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('a', 1).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Cor.Branca, Tabuleiro), new PosicaoXadrez('h', 1).ToPosicao());

            Tabuleiro.ColocarPeca(new Torre(Cor.Ciano, Tabuleiro), new PosicaoXadrez('a', 8).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Cor.Ciano, Tabuleiro), new PosicaoXadrez('h', 8).ToPosicao());
        }
    }
}
