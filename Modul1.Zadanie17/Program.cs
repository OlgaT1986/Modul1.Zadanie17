using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Modul1.Zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.Input();
            Console.WriteLine(bankAccount1.GetInfo());
            Console.WriteLine();
            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.Input();
            Console.WriteLine(bankAccount2.GetInfo());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

