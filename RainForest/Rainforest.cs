using System;
using System.Collections.Generic;

namespace RainForest {
    class Program {
        static void Main (string[] args) {
            Company rainforest = new Company ("Rainforest, LLC");

            string[] cities = new string[] { "Austin", "Houston", "Dallas", "San Antonio" };
            string[] items = new string[] { "Banana", "Toothpaste", "Baseball", "Laptop" };

            foreach (var city in cities) {
                rainforest.warehouses.Add (new Warehouse (city, 1));
                rainforest.warehouses.Add (new Warehouse (city, 2));
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++) {
                Warehouse warehouse = rainforest.warehouses[i];
                Container container = new Container ($"{warehouse.location}-1", i + 1);
                rainforest.warehouses[i].containers.Add (container);
            }

            for (int i = 0; i < 4; i++) {
                Container container = rainforest.warehouses[i].containers[0];
                Item item = new Item (items[i], i);
                container.items.Add (item);
            }

            rainforest.GenerateManifest ();

            Console.WriteLine ("Hello World!");
        }
    }

    class Company {
        public string name;
        public List<Warehouse> warehouses;

        public Company (string name) {
            this.name = name;
            this.warehouses = new List<Warehouse> ();
        }

        public void GenerateManifest () {
            string html = @"
                <html>
                    <head>
                      <style>
                        .company, .warehouse, .container, .item {
                            padding: 20px;
                            display: flex;
                            margin: 10px;
                            flex-wrap: wrap;
                        }
                        .warehouse {
                            background-color: lightsteelblue;
                        }
                        .container {
                            background-color: lightgreen;
                        }
                        .item {
                            background-color: lightpink;
                        }
                      </style>
                    </head>
                    <body>
            ";
            html += String.Format (@"
                <h1>{0}</h1>
                <div class='company'>
            ", this.name);

            foreach (var warehouse in this.warehouses) {
                html += String.Format ("<div class=\"warehouse\">{0}", warehouse.location);
                foreach (var container in warehouse.containers) {
                    html += String.Format ("<div class=\"container\">{0}", container.id);
                    foreach (var item in container.items) {
                        html += String.Format ("<div class=\"item\">{0}</div>", item.name);
                    }
                    html += "</div>";
                }
                html += "</div>";
            }
            html += "</div>";
            html += "</html>";

            System.IO.File.WriteAllText (@"./index.html", html);
        }
    }

    class Warehouse {
        public string location;
        public int size;
        public List<Container> containers;

        public Warehouse (string location, int size) {
            this.location = location;
            this.size = size;
            this.containers = new List<Container> ();
        }

    }

    class Container {
        public List<Item> items;
        public int size;
        public string id;

        public Container (string id, int size) {
            this.id = id;
            this.size = size;
            this.items = new List<Item> ();
        }

    }

    class Item {
        public string name;
        public double price;

        public Item (string name, double price) {
            this.name = name;
            this.price = price;
        }

    }
}
