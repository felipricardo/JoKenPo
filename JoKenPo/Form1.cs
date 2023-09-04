using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {

        }

        private void btnPapel_Click(object sender, EventArgs e)
        {

        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {

        }

        private void StarGame(int opcao)
        {
            labelResultado.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("images/Ganhar.png");
                    break;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("images/Perder.png");
                    break;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("images/Empatar.png");
                    break;
                default:
                    break;
            }
        }
    }
}
