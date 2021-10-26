using AutomaticCashier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Models
{
    public class ConfigureWithdrawalMenu
    {
        public int TheOption = 0;        
        Withdrawal withdrawal = new();
        IPayOption payOption;
        int option = 0;        
        public void Menu()
        {
            Console.Clear();

            try
            {
                Console.WriteLine("---|Bienvenido al cajero automatico|---\n" +
                    "¿Como desea retirar su dinero? \n" +
                "1- Primero (200 y 1000)\n" +
                "2- Segundo (100 y 500)\n" +
                "3- Eficiente (100, 200, 500 y 1000)\n" +
                "4- Volver al menu principal");
                
                Console.Write("\nEliga alguna de las opciones disponibles: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case (int)ConfigureWithdrawalOptions.First:
                        payOption = new PayOptionOne();
                        payOption.PayMethod(withdrawal.PayMethod());                       
                        break;
                    case (int)ConfigureWithdrawalOptions.Second:
                        payOption = new PayOptionSecond();
                        payOption.PayMethod(withdrawal.PayMethod());
                        break;
                    case (int)ConfigureWithdrawalOptions.Efficient:
                        payOption = new PayOptionEfficient();
                        payOption.PayMethod(withdrawal.PayMethod());
                        break;
                    case (int)ConfigureWithdrawalOptions.Exit:
                        Console.WriteLine("Hablamo' nunca...");
                        break;
                    default:
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
