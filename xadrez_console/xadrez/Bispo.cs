using System;
using tabuleiro;

namespace xadrez {
    internal class Bispo: Peca {

        public Bispo(Tabuleiro tab,Cor cor) : base(tab,cor) {
        }
        public override string ToString() {
            return "B";
        }
        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linha,tab.coluna];

            Posicao pos = new Posicao(0,0);

            //Nordeste - NE
            pos.definirValores(posicao.linha - 1,posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 1,pos.coluna + 1);
            }
            //Noroeste - NO
            pos.definirValores(posicao.linha - 1,posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 1,pos.coluna - 1);
            }
            //Sudeste - SE
            pos.definirValores(posicao.linha + 1,posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 1,pos.coluna + 1);
            }
            //Sudoeste - SO
            pos.definirValores(posicao.linha + 1,posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 1,pos.coluna - 1);
            }
            return mat;
        }
    }
}