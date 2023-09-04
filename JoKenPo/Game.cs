using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    class Game
    {
        // Enumeração para representar os resultados do jogo
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        // Array de imagens para representar as escolhas possíveis
        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        // Propriedades para armazenar as imagens escolhidas pelo jogador e pelo computador
        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        // Método para realizar uma jogada e determinar o resultado
        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC(); // Chama o método para a jogada do computador

            ImgJogador = images[jogador]; // Define a imagem escolhida pelo jogador
            ImgPC = images[pc]; // Define a imagem escolhida pelo computador

            if (jogador == pc)
            {
                return Resultado.Empatar; // Retorna empate se as escolhas forem iguais
            }
            else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                return Resultado.Ganhar; // Retorna ganhar se o jogador vencer
            }
            else
            {
                return Resultado.Perder; // Retorna perder se o jogador perder
            }
        }

        // Método para gerar uma jogada aleatória para o computador
        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0; // Escolhe Pedra
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1; // Escolhe Tesoura
            }
            else
            {
                return 2; // Escolhe Papel
            }
        }
    }
}
