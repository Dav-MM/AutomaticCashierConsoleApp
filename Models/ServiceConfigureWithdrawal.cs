using CajeroAutomatico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCashier.Models
{
    class ServiceConfigureWithdrawal : IPayOption 
    {
        public int HowMuchUWant { get; set; }
        public int TheOption { get; set; }

        public int ElMachiquito { get; set; }
        public void PayMethod(int howMuchUWant, int theOption)
        {
        
        }
        public void PayMethod(int howMuchUWant)
        {
            throw new NotImplementedException();
        }

        public bool Validation(int howMuchUWant, int elMachiquito)
        {
            if (howMuchUWant % elMachiquito != 0)
            {
                Console.WriteLine("Mi hermano, ponga un numero entero. Aquí no hay papeleta' de 50 ni moneda de 25");
                Console.ReadKey();
                PayMethod(howMuchUWant, TheOption);
                return false;
            }
            return true;
        }
    }
}
