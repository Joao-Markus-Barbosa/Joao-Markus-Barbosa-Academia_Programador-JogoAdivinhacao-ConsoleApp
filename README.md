# Jogo de Adivinhação em C# - Atividade da Academia do Programador

[![Versão 2.0](https://img.shields.io/badge/versão-2.0-blue)](https://github.com/seu-usuario/repositorio/releases/tag/v2.0)

Um jogo de adivinhação simples desenvolvido em C# onde o jogador tenta adivinhar um número secreto gerado aleatoriamente.

## 📋 Descrição

O programa gera um número aleatório entre 1 e 20, e o jogador deve tentar adivinhar qual é esse número dentro de um número limitado de tentativas, que varia de acordo com o nível de dificuldade escolhido.

## 🎮 Funcionalidades

### 🔹 Funcionalidades Existentes (1.0)
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

### 🚀 Novidades na Versão 2.0
- **Arquitetura Refatorada**:
  - Código organizado em métodos especializados
  - Lógica separada por responsabilidades
  - Manutenção simplificada

- **Melhorias de Código**:
  - Variáveis renomeadas para maior clareza (mantendo suas abreviações preferidas)
  - Eliminação de código duplicado
  - Estrutura mais preparada para futuras expansões

- **Experiência do Desenvolvedor**:
  - Métodos auto-documentados
  - Facilidade para adicionar novos recursos
  - Código mais testável

## 📦 Estrutura do Projeto (2.0)
```plaintext
Program.cs
├── MostrarCabecalho()
├── ObterDificuldade()
├── GerarNrSecreto()
├── Jogar()
│   ├── MostrarStatus()
│   ├── ObterNrValido()
│   ├── NrJaChutado()
│   └── VerificarAcerto()
└── DesejaContinuar()
