using System.Linq;
using System.Windows.Forms;

namespace Jogo_da_Velha___Final
{
    internal class Jogo
    {
        private bool index = true;
        private string[] jogador = new string[2];
        private string[] possibilidades = new string[] { "123", "456", "789", "147", "258", "369", "159", "357" };

        public bool getIndex()
        {
            return this.index;
        }

        public void setMovimentoJogador(int movimento)
        {
            if (checkGanhador(jogador[this.index ? 1 : 0] += movimento))
                MessageBox.Show("Jogador " + (this.index ? 1 : 2) + " ganhou!");
            this.index = !this.index;
        }

        private bool checkExist(string gabarito, string jogada)
        {
            foreach(char c in gabarito)
                if (!jogada.Contains(c))
                    return false;
            return true;
        }

        private bool checkGanhador(string jogadas)
        {
            foreach (string p in possibilidades)
                if (checkExist(p, jogadas))
                    return true;
            return false;
        }
    }
}
