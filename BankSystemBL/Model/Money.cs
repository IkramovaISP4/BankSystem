using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBL.Model
{
    public class Money
    {
        public double MoneyCount { get; set; } = 0;

        public Money()
        {
            
        }

        public override string ToString()
        {
            return MoneyCount.ToString();
        }
    }
}
