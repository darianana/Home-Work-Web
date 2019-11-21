using System;
using System.Collections.Generic;

namespace Work_Theatre
{
    public class DirectorWork
    {
        public static List<Director> Account = new List<Director>();

        public static void AddAccount(string name, string password)
        {
            Account.Add(new Director(name, password));
           // Console.Write("Success!\r\n");
        }

        public static int FindId(string name)
        {
            return(Account.FindIndex(Account => Account.Login == name));
        }

        public static bool IsDirector(string name)
        {
            int id = -1;
            id = FindId(name);
            if (id != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckPassword(string name, string password)
        {
            if (IsDirector(name))
            {
                if (Account[FindId(name)].Password == password)
                {
                    return true;
                }
                else
                {
                    Console.Write("Password error, try again");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}