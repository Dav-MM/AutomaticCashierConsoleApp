using CajeroAutomatico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCashier.Models
{
    class PayOptionOne : ServiceConfigureWithdrawal ,IPayOption
    {
        public int Dociento { get; set; } = 200;
        public int Mil { get; set; } = 1000;
        Withdrawal withdrawal = new();


        public void PayMethod(int howMuchUWant)
        {
            ConfigureWithdrawalMenu configureWithdrawalMenu = new();

            int residuo = howMuchUWant;
            int countMil = 0;
            int countDociento = 0;

            if (Validation(howMuchUWant,Dociento) == true)
            {
                while (residuo != 0)
                {
                    if (residuo >= Mil)
                    {
                        residuo -= Mil;
                        countMil++;
                    }
                    else if(residuo < Mil && residuo >= Dociento)
                    {
                        residuo -= Dociento;
                        countDociento++;
                    }
                }
                Console.WriteLine($"El monto que le ha sido entregado es de: {howMuchUWant}\n" +
                    $"Se le ha entregado este monto en {countMil} papeletas de 1000 y en {countDociento} de 200 :P\n" +
                    $"Presione cualquier tecla para continuar");
                Console.ReadKey();
                configureWithdrawalMenu.Menu();

            }
            

        }
    }
}
