# Jogo de Adivinhação em C# - Atividade da Academia do Programador

Um jogo de adivinhação simples desenvolvido em C# onde o jogador tenta adivinhar um número secreto gerado aleatoriamente.

## 📋 Descrição

O programa gera um número aleatório entre 1 e 20, e o jogador deve tentar adivinhar qual é esse número dentro de um número limitado de tentativas, que varia de acordo com o nível de dificuldade escolhido.

## 🎮 Funcionalidades

- **Sistema de Dificuldade**: 
  - Fácil (10 tentativas)
  - Normal (5 tentativas)
  - Difícil (3 tentativas)
  
- **Controle de Tentativas**: Mostra quantas tentativas restam e quais números já foram chutados

- **Sistema de Pontuação**: 
  - Começa com 1000 pontos
  - Perde pontos proporcionalmente ao erro (quanto mais distante do número secreto, mais pontos perde)
  
- **Validação de Entrada**:
  - Impede que o jogador chute números repetidos
  - Fornece dicas se o palpite foi maior ou menor que o número secreto
