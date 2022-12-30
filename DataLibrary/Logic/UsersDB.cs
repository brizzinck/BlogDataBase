using DataLibrary.DBAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class UsersDB
    {
        public static void  CreateUser(int _age, string _name, string _surname, 
            string _email, string _password)
        {
            UsersModel usersModel = new UsersModel
            {
                age = _age,
                name = _name,
                surname = _surname,
                email = _email,
                password = _password
            };
            string sql = @"INSERT INTO dbo.Users2 (age, name, surname, email, password)
                         VALUES(@age, @name, @surname, @email, @password)";
            SqlWorkflow.SaveData(sql, usersModel);
        }

        public static List<UsersModel> LoadUsers()
        {
            string sql = @"SELECT * FROM dbo.Users2";
            return SqlWorkflow.LoadData<UsersModel>(sql);
        }
    }
}
