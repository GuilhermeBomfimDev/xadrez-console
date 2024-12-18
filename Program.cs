using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 7));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 1));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 2));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 6));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}