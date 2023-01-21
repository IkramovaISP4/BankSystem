using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBL.Model
{
    public class User
    {
        public string Name { get; }
        public string Email { get; set; }

        public int BirthData { get; }

        public double Money { get; set; } = 0;

        #region Конструктор класса пользователя и проверка условий
        public User(string name, string email, int birthData)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть null",nameof(name));
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("Email пользователя не может быть null", nameof(email));
            }
            if (birthData<18)
            {
                throw new ArgumentNullException("Вам должно быть не менее 18 лет", nameof(birthData));
            }

            Name = name;
            Email = email;
            BirthData = birthData;
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }
    }
}
