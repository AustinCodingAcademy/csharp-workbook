using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    public static void Main()
    {
        do 
        {
            DrawBoard();
            GetInput();

        } while (!CheckForWin() && !CheckForTie())

        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }

    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());
    }

    public static void PlaceMark(int row, int column)
    {
       // your code goes here
    }

    public static bool CheckForWin()
    {
        // your code goes here
    }

    public static bool CheckForTie()
    {
        // your code goes here
    }
    
    public static bool HorizontalWin()
    {
       // your code goes here
    }

    public static bool VerticalWin()
    {
        // your code goes here
    }

    public static bool DiagonalWin()
    {
        // your code goes here
    }

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
    }
}
