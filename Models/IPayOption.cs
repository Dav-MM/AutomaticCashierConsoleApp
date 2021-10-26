using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Models
{
    interface IPayOption
    {
        public int HowMuchUWant { get; set; }
        public int TheOption { get; set; }
        
        public void PayMethod(int howMuchUWant);
        
        
        

    }
}
