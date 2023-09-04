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

        // Manipulador de evento para o botão "Pedra"
        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0); // Inicia o jogo com a escolha de Pedra (0)
        }

        // Manipulador de evento para o botão "Papel"
        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(2); // Inicia o jogo com a escolha de Papel (2)
        }

        // Manipulador de evento para o botão "Tesoura"
        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(1); // Inicia o jogo com a escolha de Tesoura (1)
        }

        // Método para iniciar o jogo com a escolha do jogador
        private void StartGame(int opcao)
        {
            labelResultado.Visible = false; // Oculta o rótulo de resultado
            Game jogo = new Game(); // Cria uma instância do jogo

            // Determina o resultado do jogo e atualiza a interface gráfica
            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png"); // Define a imagem de vitória
                    goto default; // Vai para o caso padrão para atualizar as imagens dos movimentos
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png"); // Define a imagem de derrota
                    goto default; // Vai para o caso padrão para atualizar as imagens dos movimentos
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png"); // Define a imagem de empate
                    goto default; // Vai para o caso padrão para atualizar as imagens dos movimentos
                default:
                    pictureBox1.Image = jogo.ImgJogador; // Define a imagem do movimento do jogador
                    pictureBox2.Image = jogo.ImgPC; // Define a imagem do movimento do computador
                    break;
            }
        }
    }
}