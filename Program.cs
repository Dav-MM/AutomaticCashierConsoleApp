using AutomaticCashier.Models;
using CajeroAutomatico.Models;
using System;

namespace AutomaticCashier
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new();
            menu.Menu();
        }
    }
}
