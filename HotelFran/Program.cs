using System;
using System.Globalization;
using System.Collections.Generic;


namespace HotelFran

{
    internal class Program
    {


        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Hotel[] vect = new Hotel[11];

            while (true)
            {
                
                Console.Clear();
                hotel.MenuPrincipal();
                int opMenu = hotel.ObterOpcaoMenu();

                switch (opMenu)
                {
                    case 0:
                        hotel.EncerrarPrograma();
                        break;
                    case 1:
                        hotel.CadastrarQuarto(vect);
                        break;
                    case 2:
                        hotel.MostrarQuartosVagosOcupados(vect);
                        break;
                    case 3:
                        hotel.MostrarCafe();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }



            }
        }
    }
}

