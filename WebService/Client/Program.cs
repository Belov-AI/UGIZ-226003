using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            var user = new User("student");
            users.Add(user);
            //user.PrintInfo();

            var regUser = new RegisteredUser("admin", "12345", "admin@mail.ru");
            users.Add(regUser);
            //regUser.PrintInfo();

            object obj = new User();

            Console.WriteLine(obj);

            if (obj is User userObj)
                userObj.PrintInfo();

            var usr = obj as User;
            users.Add(usr);

            foreach (var u in users)
                u.PrintInfo();

            Console.ReadKey(); 

        }
    }
}
