using System;
using System.Threading;
using SimpleHttp;
using System.IO;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace WebServer
{
    class Program
    {
        static SqliteConnectionStringBuilder connectionStringBuilder = new SqliteConnectionStringBuilder();
        
        static void Main()
        {
            connectionStringBuilder.DataSource = "./database.db";

            Route.Add("/items", (request, response, args) => {
                response.AsText(getItems());
            });

            Route.Add("/items", (request, response, args) => {
                RunQuery($@"
                    INSERT into items (name, price, container_id)
                    VALUES ('milk', '2.99', 1);
                ");
                response.AsText(getItems());
            }, "POST");

            //run the server
            int port = 8000;
            Console.WriteLine($"Running Server On http://127.0.0.1:{port}");
            HttpServer.ListenAsync(port, CancellationToken.None, Route.OnHttpRequestAsync).Wait();
        }

        static string getItems()
        {
            List<Dictionary<string, string>> results = RunQuery(@"
                SELECT *
                FROM items;
            ");
            string stringResults = PrintResults(results);
            stringResults += @"
                <br /><br />
                <form action='/items' method='POST'>
                    <label> Name
                        <input name='name' />
                    </label>
                    <label> Price ($)
                        <input name='price' />
                    </label>
                    <label> Price ($)
                        <select name='container_id'>
                            <option value='1'>Austin-1</option>
                            <option value='2'>San Antonio-1</option>
                            <option value='3'>Houston-1</option>
                            <option value='4'>Dallas-1</option>
                        </select>
                    </label>
                    <input type='Submit' value='Submit' />
                </form>
            ";
            return stringResults;
        }

        static List<Dictionary<string, string>> RunQuery(string query)
        {
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = query;
                SqliteDataReader reader = selectCmd.ExecuteReader();
                List<Dictionary<string, string>> results = getResults(reader);
                reader.Close();
                connection.Close();
                return results;
            }
        }

        static List<Dictionary<string, string>> getResults(SqliteDataReader reader)
        {
            List<Dictionary<string, string>> results = new List<Dictionary<string, string>>();
            int row = 0;
            while (reader.Read()){
                results.Add(new Dictionary<string, string>());
                for (var column = 0; column < reader.FieldCount; column++)
                {
                    results[row].Add(reader.GetName(column), reader.GetString(column));
                }
                row++;
            }
            return results;
        }

        static string PrintResults(List<Dictionary<string, string>> results)
        {
            string resultsString = "";
            foreach (var result in results)
            {
                System.Collections.Generic.IEnumerable<string> lines = result.Select(kvp => kvp.Key + ": " + kvp.Value);
                resultsString += String.Join(Environment.NewLine, lines);
            }
            return resultsString;
        }
    }
}
