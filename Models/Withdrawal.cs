using CajeroAutomatico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCashier.Models
{
    class Withdrawal
    {
        public int PayMethod()
        {          
            Console.WriteLine("Ingrese la cifra a retirar: ");
            int howMuchUWant = Convert.ToInt32(Console.ReadLine());

            return howMuchUWant;
        }
        public void PayMethodMenu()
        {
            PayOptionEfficient payOptionEfficient = new();

            Console.WriteLine("Ingrese la cifra a retirar: ");
            int howMuchUWant = Convert.ToInt32(Console.ReadLine());            
        }

    }
}
