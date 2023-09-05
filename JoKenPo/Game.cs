using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JoKenPo.Game;

namespace JoKenPo
{
    class Game
    {
        // Enumeração para representar os resultados do jogo
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public enum Jogada
        {
            Pedra, Papel, Tesoura
        }

        // Array de imagens para representar as escolhas possíveis
        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png"),
        };

        // Propriedades para armazenar as imagens escolhidas pelo jogador e pelo computador
        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        // Método para realizar uma jogada e determinar o resultado
        public Resultado Jogar(Jogada jogador)
        {
            Jogada pc = JogadaPC(); // Chama o método para a jogada do computador

            ImgJogador = images[(int)jogador]; // Define a imagem escolhida pelo jogador
            ImgPC = images[(int)pc]; // Define a imagem escolhida pelo computador

            if (jogador == pc)
            {
                return Resultado.Empatar; // Retorna empate se as escolhas forem iguais
            }
            else if ((jogador == Jogada.Pedra && pc == Jogada.Tesoura) 
                    || (jogador == Jogada.Papel && pc == Jogada.Pedra) 
                    || (jogador == Jogada.Tesoura && pc == Jogada.Papel))
            {
                return Resultado.Ganhar; // Retorna ganhar se o jogador vencer
            }
            else
            {
                return Resultado.Perder; // Retorna perder se o jogador perder
            }
        }

        // Método para gerar uma jogada aleatória para o computador
        private Jogada JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return Jogada.Pedra; // Escolhe Pedra
            }
            else if (mil >= 333 && mil < 667)
            {
                return Jogada.Tesoura; // Escolhe Tesoura
            }
            else
            {
                return Jogada.Papel; // Escolhe Papel
            }
        }
    }
}
