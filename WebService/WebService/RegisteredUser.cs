using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class RegisteredUser : User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public RegisteredUser(string login, string password, string email) : base(login)
        { 
            Password = password;
            Email = email;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Зарегиcтрированный пользователь {Login}, e-mail: {Email}");
        }
    }
}
