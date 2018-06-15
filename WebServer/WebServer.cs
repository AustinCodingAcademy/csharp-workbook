using System;
using System.Threading;
using SimpleHttp;
using System.IO;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Linq;

namespace WebServer
{
    class Program
    {
        static SqliteConnectionStringBuilder connectionStringBuilder = new SqliteConnectionStringBuilder();
        static string style = @"
            <style>
                .items {
                    display: flex;
                    flex-wrap: wrap;
                }
                .item {
                    min-width: 200px;
                    padding: 10px;
                    background-color: aliceblue;
                    margin: 10px;
                }
            </style>
        ";
        
        static void Main()
        {
            connectionStringBuilder.DataSource = "./database.db";

            Route.Add("/", (request, response, args) => {
                response.AsText("Hello, World!");
            }, "GET");

            Route.Add("/items", (request, response, args) => {
                response.AsText($"{style}{getItems()}");
            }, "GET");

            Route.Add("/items", (request, response, args) => {
                request.ParseBody(args);
                if (args.ContainsKey("_method") && args["_method"] == "DELETE") {
                    RunQuery($@"
                        DELETE FROM items
                        WHERE items.id = {args["id"]};
                    ");
                } else {
                    RunQuery($@"
                        INSERT into items (name, price, container_id)
                        VALUES ('{args["name"]}', '{args["price"]}', {args["container_id"]});
                    ");
                }
                response.AsText($"{style}{getItems()}");
            }, "POST");

            //run the server
            int port = 8000;
            Console.WriteLine($"Running Server On http://127.0.0.1:{port}");
            HttpServer.ListenAsync(port, CancellationToken.None, Route.OnHttpRequestAsync).Wait();
        }

        static string getItems()
        {
            var results = RunQuery($@"  
                SELECT *
                FROM items;
            ");
            string html = $@"
                <div class='items'>
                    {String.Join("", results.Select(item => $@"
                        <div class='item'>
                            <form method='POST' action='/items'>
                                <input type='hidden' name='_method' value='DELETE'>
                                <input type='hidden' name='id' value='{item["id"]}'>
                                <input type='submit' value='X' style='float: right'>
                            </form>
                            id: {item["id"]}
                            <br>
                            name: {item["name"]}
                        </div>
                    "))}
                </div>
            ";
            html += @"
                <br/><br/>
                <form method='POST' action='/items'>
                    <label>Name
                        <input name='name' />
                    </label>
                    <label>Price
                        <input name='price' />
                    </label>
                    <label>Container
                        <select name='container_id'>
                            <option value='1'>Austin-1</option>
                            <option value='2'>San Antonio-1</option>
                            <option value='3'>Houston-1</option>
                            <option value='4'>Dallas-1</option>
                        </select>
                    </label>
                    <input type='submit' value='Submit' />
                </form>
            ";
            return html;
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
                resultsString += $"{String.Join("<br/>", lines)}\n";
            }
            return resultsString;
        }
    }
}
