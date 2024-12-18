using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        public static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            
            Console.WriteLine(pos.toPosicao());

            /*try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 9));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }*/
            
        }
    }
}