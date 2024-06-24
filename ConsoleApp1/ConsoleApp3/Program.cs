using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class User
    {
        public string Login { get; set; }
        private string password;
        public string Password;

        public void OpenConnection()
        {
            Console.WriteLine("Db is opened");
        }

        public void Save()
        {
            Console.WriteLine(Login + "is saved");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Connection is closed");
        }

    }

        public void 
        {
            get { return password; }
            set { if (value.Length >= 6)
                    password = value;
                else
                    throw new Exception("Password can`t be less 6 symbols");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                User user = new User();
                user.Password = "";
            }
        }
    } }
