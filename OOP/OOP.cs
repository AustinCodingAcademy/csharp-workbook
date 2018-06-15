using System;

namespace OOP {

    class Program {
        static void Main () {
            Person leia = new Person ("Leia", "Organa", "Rebel");
            Person darth = new Person ("Darth", "Vader", "Imperial");
            Person[] rebels = Person.CreatePerson ("Luke Skywalker Rebel", "Han Solo Rebel", "Obi-wan Kenobi Rebel");
            Ship falcon = new Ship ("Rebel", "Smuggling", 2);
            Ship tie = new Ship ("Tie", "Fighter", 1);
            Console.WriteLine ("Hello world!");
        }

    }

    class Person {
        static public string hello = "world";
        static public Person[] CreatePerson (params string[] descriptions) {
            Person[] people = new Person[descriptions.Length];
            for (var i = 0; i < descriptions.Length; i++)
            {
                string[] attributes = descriptions[i].Split(" ");
                people[i] = new Person(attributes[0], attributes[1], attributes[2]);
            }
            return people;
        }
        private string firstName;
        private string lastName;
        private string alliance;
        public Person (string firstName, string lastName, string alliance) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.alliance = alliance;
        }

        public string FullName {
            get {
                return this.firstName + " " + this.lastName;
            }

            set {
                string[] names = value.Split (' ');
                this.firstName = names[0];
                this.lastName = names[1];
            }
        }
    }

    class Ship {
        private Person[] passengers;

        public Ship (string alliance, string type, int size) {
            this.Type = type;
            this.Alliance = alliance;
            this.passengers = new Person[size];
        }

        public string Type { get; set; }
        public string Alliance { get; set; }

        public string Passengers {
            get {
                foreach (var person in passengers) {
                    Console.WriteLine (String.Format ("{0}", person.FullName));
                }
                return "That's Everybody!";
            }
        }

        public void EnterShip (Person person, int seat) {
            this.passengers[seat] = person;
        }

        public void ExitShip (int seat) {
            this.passengers[seat] = null;
        }
    }

    class Station {

    }
}
