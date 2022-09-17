using System;
using System.Windows.Forms;

namespace Jogo_da_Velha___Final
{
    public partial class Form1 : Form
    {
        private Jogo jogo = new Jogo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = jogo.getIndex() ? Properties.Resources.x : Properties.Resources.o;
            jogo.setMovimentoJogador(int.Parse((sender as Button).Text));
        }
    }
}
