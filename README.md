# JoKenPo - Jogo Pedra, Papel e Tesoura

![Screenshot](https://www.fschuch.com/blog/2019/07/23/desafio-de-programacao-o-jogo-pedra-papel-e-tesoura/featured.png)

## Descrição

Este é um jogo simples de "Pedra, Papel e Tesoura" (JoKenPo) implementado em C# usando Windows Forms. Os jogadores podem escolher entre "Pedra", "Papel" e "Tesoura", e o jogo determina o resultado da rodada.

## Funcionalidades

- Escolha entre "Pedra", "Papel" e "Tesoura".
- Jogue contra o computador.
- Visualize o resultado de cada rodada.
- Imagens representativas das escolhas e do resultado.

## Como Jogar

1. Clone o repositório ou faça o download dos arquivos.
2. Abra o projeto em um ambiente de desenvolvimento C# compatível, como o Visual Studio.
3. Execute o jogo.
4. Clique nos botões "Pedra", "Papel" ou "Tesoura" para fazer a sua escolha.
5. Veja o resultado da rodada exibido na tela.

## Recursos

- [Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-6.0) - Framework utilizado para criar a interface gráfica.
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - Linguagem de programação utilizada para desenvolver o jogo.

## Captura de Tela

![Screenshot](https://i.ibb.co/8zts2x7/Captura-de-tela-2023-09-04-144026.png)

## Autor

Felipe Ricardo

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para criar um fork deste projeto e propor melhorias ou correções.

## Licença

Este projeto está licenciado sob a Licença [MIT](LICENSE).

---
# pseudocodigo de Game.cs:

```
INÍCIO DO PROGRAMA
    Crie uma classe chamada "Game"

    Dentro da classe "Game":
        Crie uma enumeração chamada "Resultado" com os valores: Ganhar, Perder, Empatar
        Crie uma enumeração chamada "Jogada" com os valores: Pedra, Papel, Tesoura
        Crie um array de imagens chamado "images" para representar escolhas possíveis
        Crie propriedades "ImgPC" e "ImgJogador" para armazenar imagens escolhidas
        Crie um método chamado "Jogar" que aceita a escolha do jogador e retorna o resultado do jogo
        Crie um método privado chamado "JogadaPC" para gerar uma jogada aleatória para o computador

    Dentro do método "Jogar":
        Determine a jogada do computador chamando o método "JogadaPC"
        Defina as imagens escolhidas pelo jogador e pelo computador
        Se a escolha do jogador for igual à escolha do computador, retorne "Empatar"
        Senão, se o jogador ganhar, retorne "Ganhar"
        Senão, retorne "Perder"

    Dentro do método privado "JogadaPC":
        Gere um número aleatório usando o milissegundo atual
        Se o número for menor que 333, escolha "Pedra" para o computador
        Senão, se o número estiver entre 333 e 667, escolha "Tesoura" para o computador
        Senão, escolha "Papel" para o computador

FIM DO PROGRAMA
