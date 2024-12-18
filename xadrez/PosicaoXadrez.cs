using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a'); // O char 'a' internamente é um número inteiro. 8 - linha vai cair exatamente na linha que eu desejar. Ex: quero a posição a5. a-a = 0. 8-5=3;  
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
