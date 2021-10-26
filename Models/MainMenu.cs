using AutomaticCashier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Models
{
    public class MainMenu
    {
        IPayOption payOption;
        Withdrawal withdrawal = new();
        int option = 0;
        ConfigureWithdrawalMenu configureWithdrawalMenu = new();
        public void Menu()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("---|Bienvenido al cajero automatico|---\n" +
                "1- Configurar el modo de retiro\n" +
                "2- Retiro\n" +
                "3- Salir");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Write("Eliga alguna de las opciones disponibles: ");

                switch (option)
                {
                    case (int) MainMenuOptions.ConfigureWithdrawal:
                        configureWithdrawalMenu.Menu();
                        Menu();
                        break;
                    case (int)MainMenuOptions.Withdawal:
                        payOption = new PayOptionEfficient();
                        payOption.PayMethod(withdrawal.PayMethod());
                        break;
                    case (int)MainMenuOptions.Exit:
                        Console.Clear();
                        Console.WriteLine("Hablamo' nunca...");
                        break;
                    default:
                        Console.WriteLine("Miop, eliga alguna de las opciones disponibles...");
                        Console.ReadKey();
                        Menu();
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Menu();
            }
        }
    }
}
