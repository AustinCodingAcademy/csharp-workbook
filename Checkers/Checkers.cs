using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] whitePositions = new int[][] {
                new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0, 5 }, new int[] { 0, 7 },
                new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 1, 6 },
                new int[] { 2, 1 }, new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 2, 7 }
            };
            

            int[][] blackPositions = new int[][] {
                new int[] { 5, 0 }, new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 5, 6 },
                new int[] { 6, 1 }, new int[] { 6, 3 }, new int[] { 6, 5 }, new int[] { 6, 7 },
                new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 }
            };

            Board board = new Board();
            
            for (int i = 0; i < 12; i++)
            {
                Checker white = new Checker("white", whitePositions[i]);
                Checker black = new Checker("black", blackPositions[i]);
                board.Checkers.Add(white);
                board.Checkers.Add(black);
            }
            board.DrawBoard();
            Console.WriteLine("Select checker row:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select checker column:");
            int col = Convert.ToInt32(Console.ReadLine());

            Checker checker = board.SelectChecker(row, col);
            Console.WriteLine("Move to which row:");
            int newRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Move to which column:");
            int newCol = Convert.ToInt32(Console.ReadLine());

            checker.Position = new int[]{ newRow, newCol };

            board.DrawBoard();

            Console.WriteLine("hello, world");
        }
    }

    public class Checker
    {
        public string Symbol  { get; set; }
        public int[] Position  { get; set; }
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
            int circleId;
            if (color == "white")
            {
                circleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                circleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            }
            this.Symbol = char.ConvertFromUtf32(circleId);
            this.Position = position;
        }
    }

    public class Board
    {
        public string[][] Grid  { get; set; }
        public List<Checker> Checkers { get; set; }
        
        public Board()
        {
            this.Checkers = new List<Checker>();
            this.CreateBoard();
            
            return;
        }
        
        public void CreateBoard()
        {
            this.Grid = new string[][] {
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
            };
            return;
        }
        
        public void GenerateCheckers()
        {
            // Your code here
            return;
        }
        
        public void PlaceCheckers()
        {
            foreach (var checker in Checkers)
            {
                Console.WriteLine(checker.Position[0] + " " + checker.Position[1]);
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
            return;
        }
        
        public void DrawBoard()
        {
            CreateBoard();
            PlaceCheckers();
            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(i + " " + String.Join(" ", this.Grid[i]));
            }
            return;
        }
        
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        
        public void RemoveChecker(Checker checker)
        {
            this.Checkers.Remove(checker);
            return;
        }
        
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }


    }

    class Game
    {
        public Game()
        {
            // Your code here
        }
    }
}
