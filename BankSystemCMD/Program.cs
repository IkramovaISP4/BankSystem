using BankSystemBL.Controller;
using BankSystemBL.Model;
using System.Runtime.Serialization.Json;

namespace BankSystemBl // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Добро пожаловать в банковскую систему");

            Console.WriteLine("Введите имя пользователя:");
            var name = Console.ReadLine();
            var userController = new UserController(name);
            if (name != null)
            {
                Console.WriteLine("Your name: " + userController.CurrentUser);
            }
            Console.WriteLine("Напишите сумму которую хотите добавить:");
            double moneyAdd =  Convert.ToDouble(Console.ReadLine());
            var mon = new Money();
            var moneyController = new MoneyController(mon, userController);
            if(moneyAdd >= 0)
            {
                moneyController.AddMoney(moneyAdd);
            }
            moneyController.GetInfo();
            Console.WriteLine("Напишите сумму которую хотите вычесть:");
            double moneyDelete = Convert.ToDouble(Console.ReadLine());

            if (moneyDelete >= 0)
            {
                moneyController.DeleteMoney(moneyDelete);
            }
            moneyController.GetInfo();
            Console.ReadKey();

        }
    }
}
