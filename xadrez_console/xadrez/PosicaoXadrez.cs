using tabuleiro;

namespace xadrez {
    internal class PosicaoXadrez {

        public char colunas { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char colunas, int linha) {
            this.colunas = colunas;
            this.linha = linha;
        }

        public Posicao toPosicao() {
            return new Posicao(8 - linha, colunas - 'a');
        }
        public override string ToString() {
            return $" {colunas} {linha}";

        }
    }
}
