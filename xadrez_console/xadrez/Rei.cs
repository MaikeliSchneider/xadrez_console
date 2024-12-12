using System;
using tabuleiro;

namespace xadrez {
    internal class Rei: Peca {

        public Rei(Tabuleiro tab,Cor cor) : base(tab,cor) {
        }
        public override string ToString() {
            return "R";
        }
        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;
        }
        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linha,tab.coluna];

            Posicao pos = new Posicao(0,0);

            //Norte - N - acima
            pos.definirValores(posicao.linha - 1,posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            //Nordeste - NE
            pos.definirValores(posicao.linha - 1,posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            //Leste - L - direita
            pos.definirValores(posicao.linha,posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            //Sudeste - SE
            pos.definirValores(posicao.linha + 1,posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            //Sul - S - abaixo
            pos.definirValores(posicao.linha + 1,posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            //Sudoeste - SO
            pos.definirValores(posicao.linha + 1,posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            //Oeste - O - esquerda
            pos.definirValores(posicao.linha,posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            //Noroeste - NO
            pos.definirValores(posicao.linha - 1,posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha,pos.coluna] = true;
            }
            return mat;
        }
    }
}
