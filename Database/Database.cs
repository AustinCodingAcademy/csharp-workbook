using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;

namespace Database{
    class Program
    {
        static SqliteConnectionStringBuilder connectionStringBuilder = new SqliteConnectionStringBuilder();
        static List<Dictionary<string, string>> results = new List<Dictionary<string, string>>();

        static void Main(string[] args)
        {
            connectionStringBuilder.DataSource = "./database.db";
            SqliteDataReader reader = RunQuery(@"
                SELECT items.name, warehouses.location
                FROM items
                JOIN containers ON items.container_id = containers.id
                JOIN warehouses ON containers.warehouse_id = warehouses.id;
            ");
            PrintResults(reader);
        }

        static SqliteDataReader RunQuery(string query)
        {
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = query;
                return selectCmd.ExecuteReader();
            }
        }

        static void PrintResults(SqliteDataReader reader)
        {
            results.Clear();
            var row = 0;
            while (reader.Read()){
                results.Add(new Dictionary<string, string>());
                for (var column = 0; column < reader.FieldCount; column++)
                {
                    results[row].Add(reader.GetName(column), reader.GetString(column));
                }
                var lines = results[row].Select(kvp => kvp.Key + ": " + kvp.Value.ToString());
                Console.WriteLine(String.Join(Environment.NewLine, lines));
                Console.WriteLine("");
                row++;
            }
        }
    }
}
