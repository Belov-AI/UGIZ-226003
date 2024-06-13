using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class User
    {
        static readonly string logFileName;
        public string Login {  get; set; }

        public User(string login)
        {
            Login = login;
        }

        public User() : this("guest") { }

        static User()
        {
            logFileName = "log.txt";
        }

        ~User() 
        {
            Console.WriteLine($"Пользователь {Login} удален");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Пользователь {Login}");
        }

        public override string ToString()
        {
            return "Пользователь: " + Login;
        }
    }
}
