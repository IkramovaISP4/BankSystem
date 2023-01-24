using BankSystemBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBL.Controller
{
    public class MoneyController
    {
        public Money Money { get; set; }
        public UserController user { get; set; }

        public MoneyController(Money money, UserController user)
        {
            Money = money;
            this.user = user;
        }

        public void AddMoney(double money)
        {
            Money.MoneyCount += money;
        }

        public void DeleteMoney(double money)
        {
            Money.MoneyCount -= money;
        }

        public void GetInfo()
        {
            Console.WriteLine(Money.MoneyCount+ " " + user.CurrentUser);
        }
    }
}
