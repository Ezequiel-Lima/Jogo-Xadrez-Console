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

                while (!partidaDeXadrez.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partidaDeXadrez.Tabuleiro);
                        Console.WriteLine("\nTurno:" + partidaDeXadrez.Turno);
                        Console.WriteLine("Aguardando jogada: " + partidaDeXadrez.JogadorAtual);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partidaDeXadrez.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partidaDeXadrez.Tabuleiro.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partidaDeXadrez.Tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partidaDeXadrez.ValidarPosicaDeDestino(origem, destino);

                        partidaDeXadrez.RealizaJogada(origem, destino);
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine($"{error.Message}");
                        Console.ReadKey();
                    }             
                }        
            }
            catch (TabuleiroException error)
            {
                Console.WriteLine($"{error.Message}");
            }
            
            Console.ReadKey();
        }
    }
}
