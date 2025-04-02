using System;

namespace JogoDeAdivinhação.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                // Versão 4: Estrutura básica e entrada do usuário 
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Jogo da Adivinhação");
                Console.WriteLine("-----------------------------");

                //Escolha de dificuldade
                Console.WriteLine("Escolha o nível de dificuldade ");
                Console.WriteLine("1 - Fácil (10 tentativas) ");
                Console.WriteLine("2 - Normal (5 tentativas) ");
                Console.WriteLine("3 - Difícil (3 tentativas) ");

                Console.WriteLine("Digite sua escolha: ");
                string escolhaDeDificuldade = Console.ReadLine();


                int totalDeTentativas = 0;

                if (escolhaDeDificuldade == "1")
                    totalDeTentativas = 10;
                else if (escolhaDeDificuldade == "2")
                    totalDeTentativas = 5;
                else
                    totalDeTentativas = 3;



                //Escolha do número aleatório
                Random geradorDeNumeros = new Random();
                int nrSecreto = geradorDeNumeros.Next(1, 21);


                //Declarando o de números já chutados
                int[] nrChutados = new int[100];
                int contadoNrChutados = 0;

                //Sistema de pontuação
                int pontuacao = 1000;



                //Lógica do Jogo
                for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
                {

                    Console.WriteLine("----------------------------------------\n" +
                                      $"Tentativa {tentativa} de {totalDeTentativas}!\n" +
                                      "----------------------------------------");
                    Console.WriteLine("Pontuação: " + pontuacao + " pontos ");

                    Console.Write("Números já chutados: ");

                    for (int i = 0; i < nrChutados.Length; i++)
                    {
                        if (nrChutados[i] > 0) { 
                        Console.Write(nrChutados[i] + " ");
                        }
                    }


                    int nrDigitado;
                    Boolean nrRepetido;

                    //Impondo condição while para números repetidos 
                    do
                    {
                        nrRepetido = false;

                        Console.WriteLine("\nDígite um número de 1 á 20 para chutar: ");
                        nrDigitado = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i <  nrChutados.Length; i++)
                        {
                            if (nrChutados[i] == nrDigitado)
                            {
                                Console.WriteLine("Este número já foi digitado!!!\n Pressione qualquer tecla para tentar novamente...");
                                Console.WriteLine();

                                nrRepetido = true; 
                                break;
                            }
                        }


                    } while (nrRepetido == true);

                    

                    nrChutados[contadoNrChutados] = nrDigitado;
                    contadoNrChutados ++ ;

                    if (nrDigitado == nrSecreto)
                    {
                        Console.WriteLine("Parabéns, você acertou o número!");
                    }
                    else if (nrDigitado > nrSecreto)
                    {
                        Console.WriteLine("O número digitado foi maior que o número secreto! ");

                        pontuacao -= Math.Abs((nrDigitado - nrSecreto) / 2);

                    }
                    else
                    {
                        Console.WriteLine("O número digitado foi menor que o número secreto! ");
                        pontuacao -= Math.Abs((nrDigitado - nrSecreto) / 2);
                    }

                    Console.WriteLine("Precione qualquer tecla para continuar...");
                    Console.ReadLine();


                }
                Console.WriteLine("Deseja continuar? (S/N): ");
                string opContinuar = Console.ReadLine().ToUpper();

                if (opContinuar != "S")
                    break;

            }

        }
    }
}