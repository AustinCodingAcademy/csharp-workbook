using System;
using System.Data;
using Mono.Data.SqliteClient;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string connectionString = "URI=file:database.db";
            IDbConnection dbcon = new SqliteConnection(connectionString);
            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            const string sql = "SELECT * FROM albums";
            dbcmd.CommandText = sql;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                string firstName = reader.GetString(0);
                string lastName = reader.GetString(1);
                Console.WriteLine("Name: {0} {1}",
                    firstName, lastName);
            }
            // clean up
            reader.Dispose();
            dbcmd.Dispose();
            dbcon.Close();
        }
    }
}
