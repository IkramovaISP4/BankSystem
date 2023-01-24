using BankSystemBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization; 

namespace BankSystemBL.Controller
{
    public class UserController
    {
        public bool isNewUser = false;
        public User CurrentUser { get; set; }

        public List<User> users = new List<User>();

        public UserController(string userName)
        {
           // users = GetAllUsers();
            CurrentUser = users.SingleOrDefault(u => u.Name == userName);
           
            if (CurrentUser == null)
            {
                CurrentUser = new User(userName);
                users.Add(CurrentUser);
                isNewUser = true;
                //Save();
            }
        }


        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
        //public void Save()
        //{
        //    using (var fileStream = new FileStream("qw.json", FileMode.OpenOrCreate))
        //    {
        //        jsonFormatter.WriteObject(fileStream, users);
        //    }
        //}

        //public List<User> GetAllUsers()
        //{
        //    using (var fileStream = new FileStream("qw.json", FileMode.OpenOrCreate))
        //    {
        //        if (jsonFormatter.ReadObject(fileStream) is List<User> users)
        //        {
        //            return users;
        //        }
        //        else
        //        {
        //            return new List<User>();
        //        }
        //    }
        //}
    }
}
