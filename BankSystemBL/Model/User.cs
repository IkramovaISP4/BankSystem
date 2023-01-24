using BankSystemBL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBL.Model
{
    [DataContract]
    public class User
    {
        [DataMember] public string Name { get; set; }

        #region Конструктор класса пользователя
        public User(string name)
        {
            Name = name;
        }
        

        #endregion

        public override string ToString()
        {
            return Name;
        }

        
    }
}
