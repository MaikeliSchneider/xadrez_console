using System;
using tabuleiro;

namespace xadrez {
    internal class Dama: Peca {

        public Dama(Tabuleiro tab,Cor cor) : base(tab,cor) {
        }
        public override string ToString() {
            return "D";
        }
        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linha,tab.coluna];

            Posicao pos = new Posicao(0,0);

            //Oeste - O - esquerda
            pos.definirValores(posicao.linha,posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha,pos.coluna - 1);
            }
            //Leste - L - direita
            pos.definirValores(posicao.linha,posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha,pos.coluna - 1);
            }
            //Norte - N - acima
            pos.definirValores(posicao.linha - 1,posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 1,pos.coluna);
            }
            //Sul - S - abaixo
            pos.definirValores(posicao.linha + 1,posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 1,pos.coluna);
            }
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