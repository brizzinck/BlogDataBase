using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace DataLibrary.DBAccess
{
    public static class SqlWorkflow
    {
        public static string GetStringConnection()
        {
            return ConfigurationManager.ConnectionStrings["BlogDB"].ConnectionString;
        }
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection connection = new SqlConnection(GetStringConnection()))
            {
                return connection.Query<T>(sql).ToList();   
            }
        }
        public static void SaveData<T>(string sql, T data)
        {
            using (IDbConnection connection = new SqlConnection(GetStringConnection()))
            {
                connection.Execute(sql, data);
            }    
        }
    }
}
