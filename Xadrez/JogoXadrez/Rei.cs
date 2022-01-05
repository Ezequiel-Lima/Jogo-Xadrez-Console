using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez.JogoXadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroClass tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
