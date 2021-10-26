using CajeroAutomatico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCashier.Models
{
    class PayOptionSecond : ServiceConfigureWithdrawal ,IPayOption
    {
        public int Cien { get; set; } = 100;
        public int Quiniento { get; set; } = 500;
        Withdrawal withdrawal = new();


        public void PayMethod(int howMuchUWant)
        {
            ConfigureWithdrawalMenu configureWithdrawalMenu = new();

            int residuo = howMuchUWant;
            int countCien = 0;
            int countQuiniento = 0;

            if (Validation(howMuchUWant, Cien) == true)
            {
                while (residuo != 0)
                {
                    if (residuo >= Quiniento)
                    {
                        residuo -= Quiniento;
                        countQuiniento++;
                    }
                    else if(residuo < Quiniento && residuo >= Cien)
                    {
                        residuo -= Cien;
                        countCien++;
                    }
                }
                Console.WriteLine($"El monto que le ha sido entregado es de: {howMuchUWant}\n" +
                    $"Se le ha entregado este monto en {countQuiniento} papeletas de 500 y en {countCien} de 100 :P\n" +
                    $"Presione cualquier tecla para continuar");
                Console.ReadKey();
                configureWithdrawalMenu.Menu();

            }
            

        }
    }
}
