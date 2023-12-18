using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFran
{
    internal class Hotel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Hotel()
        {

        }
        public Hotel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void MenuPrincipal()
        {
            Console.Clear();
             Console.WriteLine("╔═════════════════════╗");
             Console.WriteLine("║    HOTEL DA FRAN    ║");
             Console.WriteLine("╠═════════════════════╣");
             Console.WriteLine("║ 1-CADASTRO          ║");
             Console.WriteLine("║ 2-QUARTOS OCUPADOS  ║");
             Console.WriteLine("║ 3-CAFÉ              ║");
             Console.WriteLine("║ 0-FECHAR            ║");
             Console.WriteLine("╚═════════════════════╝");
              

        }
        public int ObterOpcaoMenu()
        {
            Console.Write("\nEscolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }
        public void CadastrarQuarto(Hotel[] vect)
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║       CADASTRO      ║");
            Console.WriteLine("╚═════════════════════╝");
            Console.WriteLine();
            Console.Write("Quantos quartos serão reservados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Hotel(nome, email);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("CADASTRO CONCLUÍDO!");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
            }

        }
        public void EncerrarPrograma()
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("PROGRAMA ENCERRADO!");
              Console.ForegroundColor = ConsoleColor.White;
              Environment.Exit(0);
            }
        public void MostrarQuartosVagosOcupados(Hotel[] vect)
        {
            Console.Clear();
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║       OCUPADOS      ║");
            Console.WriteLine("╚═════════════════════╝");
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i].Nome} - {vect[i].Email}");
                }


            }
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║         VAGOS       ║");
            Console.WriteLine("╚═════════════════════╝");
            Console.WriteLine("Quartos disponíveis ainda: ");
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                if (vect[i] == null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }

            }
            Console.WriteLine();

            Console.WriteLine("Deseja voltar para o menu principal (s/n)?");
            char resp = char.Parse(Console.ReadLine().ToLower());



            if (resp == 's' || resp == 'S')
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("VOLTANDO AO MENU PRINCIPAL: ");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PROGRAMA ENCERRADO!");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);
                
            }
        }
        public void MostrarCafe()
        {
            Console.Clear();

            double ValorTotal = 0, preco = 0, ValorParcial = 0;
            string resposta = null;
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║           PADARIA DA FRANFRAN             ║");
            Console.WriteLine("╠═══════════════════════════════════════════╣");
            Console.WriteLine("║  CÓDIGO   ║    PRODUTO       ║  PREÇO     ║");
            Console.WriteLine("╠═══════════════════════════════════════════╣");
            Console.WriteLine("║     1     ║  PÃO NA CHAPA    ║   R$4.00   ║");
            Console.WriteLine("║     2     ║  CAFÉ COM LEITE  ║   R$4.50   ║");
            Console.WriteLine("║     3     ║  MISTO QUENTE    ║   R$6.00   ║");
            Console.WriteLine("║     4     ║  TORRADA SIMPLES ║   R$3.00   ║");
            Console.WriteLine("║     5     ║  CAPUCCINO       ║   R$8.50   ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");

            do
            {
                Console.WriteLine("Escolha o código do produto (ou digite 0 para finalizar o pedido): ");
                int codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        preco = 4.00;
                        break;
                    case 2:
                        preco = 4.50;
                        break;
                    case 3:
                        preco = 6.00;
                        break;
                    case 4:
                        preco = 3.00;
                        break;
                    case 5:
                        preco = 8.50;
                        break;
                    default:
                        Console.WriteLine("Código inválido!");
                        break;

                }
                ValorParcial = preco * qtd;
                ValorTotal += ValorParcial;

                Console.WriteLine($"Valor parcial: R${ValorParcial:F2}"); Console.WriteLine();
                Console.WriteLine("Deseja continuar comprando? (SIM ou NAO)");
                resposta = Console.ReadLine();
            } while (resposta == "SIM");
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║     FINALIZANDO...  ║");
            Console.WriteLine("╚═════════════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("PEDIDO FINALIZADO COM SUCESSO! ");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine($"Valor total: RS$ {ValorTotal:F2}");

            Console.WriteLine();
            Console.WriteLine("Deseja voltar para o menu principal (s/n)?");
            char resp = char.Parse(Console.ReadLine());



            if (resp == 's' || resp == 'S')
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("VOLTANDO AO MENU PRINCIPAL: ");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);

            }
            else
            {
                EncerrarPrograma();
            }
        }

        }
    }
