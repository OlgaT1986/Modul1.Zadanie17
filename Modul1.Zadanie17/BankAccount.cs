using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie17
{
    class BankAccount<T>
    {
        // номер счета
        public T NumberAccount { get; set; }  
        // баланс счета
        public int BalanceAccount { get; set; } 
        // фио
        public string Name { get; set; } 
        // метод возвращает строку
        public string GetInfo() 
        {
            return $"{NumberAccount} {BalanceAccount} {Name}";
        }
        // метод запрашивает значение
        public void Input()  
        {
            Console.WriteLine("Введите номера счета в банке");
            string stringNumber = Console.ReadLine();
            // принимает тип и возвращает значение к нужному типу
            NumberAccount = (T)Convert.ChangeType(stringNumber, typeof(T)); 
            Console.WriteLine("Введите баланс счета в банке");
            BalanceAccount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца счета в банке");
            Name = Console.ReadLine();
        }
    }
}

