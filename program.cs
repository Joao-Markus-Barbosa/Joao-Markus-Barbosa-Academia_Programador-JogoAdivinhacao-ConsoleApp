using System;

namespace JogoDeAdivinhação.ConsoleApp
{
    internal class Program
    {
        private static int pontuacao;
        private static int[] nrChutados = new int[100];
        private static int contadorNrChutados = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                MostrarCabecalho();
                int totalTentativas = ObterDificuldade();
                int nrSecreto = GerarNrSecreto();
                pontuacao = 1000;
                
                Jogar(totalTentativas, nrSecreto);

                if (!DesejaContinuar())
                    break;
            }
        }

        private static void MostrarCabecalho()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Jogo da Adivinhação");
            Console.WriteLine("-----------------------------");
        }

        private static int ObterDificuldade()
        {
            Console.WriteLine("Escolha o nível de dificuldade:");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Normal (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.Write("Digite sua escolha: ");

            string escolha = Console.ReadLine();

            return escolha switch
            {
                "1" => 10,
                "2" => 5,
                _ => 3
            };
        }

        private static int GerarNrSecreto()
        {
            Random random = new Random();
            return random.Next(1, 21);
        }

        private static void Jogar(int totalTentativas, int nrSecreto)
        {
            for (int tentativa = 1; tentativa <= totalTentativas; tentativa++)
            {
                MostrarStatus(tentativa, totalTentativas);
                
                int nrDigitado = ObterNrValido();

                if (VerificarAcerto(nrDigitado, nrSecreto))
                    return;
            }
        }

        private static void MostrarStatus(int tentativaAtual, int totalTentativas)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Tentativa {tentativaAtual} de {totalTentativas}!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Pontuação: {pontuacao} pontos");
            Console.Write("Números já chutados: ");
            
            MostrarNrChutados();
        }

        private static void MostrarNrChutados()
        {
            foreach (int nr in nrChutados)
            {
                if (nr > 0)
                    Console.Write(nr + " ");
            }
            Console.WriteLine();
        }

        private static int ObterNrValido()
        {
            int nrDigitado;
            bool nrRepetido;

            do
            {
                nrRepetido = false;
                Console.Write("\nDigite um número de 1 a 20: ");
                nrDigitado = Convert.ToInt32(Console.ReadLine());

                if (NrJaChutado(nrDigitado))
                {
                    Console.WriteLine("Este número já foi digitado!");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    nrRepetido = true;
                }

            } while (nrRepetido);

            nrChutados[contadorNrChutados++] = nrDigitado;
            return nrDigitado;
        }

        private static bool NrJaChutado(int nr)
        {
            foreach (int n in nrChutados)
            {
                if (n == nr)
                    return true;
            }
            return false;
        }

        private static bool VerificarAcerto(int nrDigitado, int nrSecreto)
        {
            if (nrDigitado == nrSecreto)
            {
                Console.WriteLine("Parabéns, você acertou o número!");
                return true;
            }

            if (nrDigitado > nrSecreto)
                Console.WriteLine("O número digitado foi maior que o número secreto!");
            else
                Console.WriteLine("O número digitado foi menor que o número secreto!");

            pontuacao -= Math.Abs((nrDigitado - nrSecreto) / 2);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            
            return false;
        }

        private static bool DesejaContinuar()
        {
            Console.Write("Deseja continuar? (S/N): ");
            return Console.ReadLine().ToUpper() == "S";
        }
    }
}
